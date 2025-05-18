using System;
using System.IO;
using System.Linq;
using System.Text;

namespace EqSpellData
{
    public class SpellParserFactory
    {
        public static SpellParserFactory Instance => _instance;
        private static readonly SpellParserFactory _instance = new();
        static SpellParserFactory() {}

        public ISpellParser GetSpellParser(string path)
        {
            var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, useAsync: true);
            return GetSpellParser(fs);
        }

        public ISpellParser GetSpellParser(Stream stream)
        {
            SpellFileFormat _fileFormat = GetSpellFileFormat(stream);
            stream.Position = 0; // reset stream for parser usage

            switch (_fileFormat)
            {
                case SpellFileFormat.Binary560:
                case SpellFileFormat.Binary608:
                    return new BinarySpellParser(stream, _fileFormat);
                case SpellFileFormat.Text139:
                case SpellFileFormat.Text147:
                    return new TextSpellParser(stream, _fileFormat);
                default:
                    throw new ArgumentException("Unsupported format", nameof(stream));
            }
        }

        private SpellFileFormat GetSpellFileFormat(Stream stream)
        {
            using var sr = new StreamReader(stream, encoding: default, detectEncodingFromByteOrderMarks: true, bufferSize: -1, leaveOpen: true);
            Span<char> buffer = new char[128];
            sr.ReadBlock(buffer);
            ReadOnlySpan<char> data = buffer;
            stream.Position = 0;

            // text spell file
            if (data.Contains(TextSpellReader.Delimiter.ToString(), StringComparison.InvariantCulture))
            {
                sr.DiscardBufferedData();
                return FingerprintTextSpells(sr);
            }

            return FingerprintBinarySpells(stream);
        }

        private SpellFileFormat FingerprintTextSpells(StreamReader streamReader)
        {
            int fieldCount = TextSpellReader.GetFieldCount(streamReader.ReadLine().AsSpan());
            return (SpellFileFormat)fieldCount;
        }

        private SpellFileFormat FingerprintBinarySpells(Stream stream)
        {
            var matchAttempts = 5;
            int[] matchPositions = new int[matchAttempts];
            for (int i = 0; i < matchPositions.Length; i++)
            {
                matchPositions[i] = FindBinarySpellPattern(stream);
            }

            // get the mode
            int structSize = matchPositions.GroupBy(i => i)
                                .OrderByDescending(g => g.Count())
                                .Select(g => g.Key)
                                .First();

            return (SpellFileFormat)structSize;
        }

        private int FindBinarySpellPattern(Stream stream)
        {
            ReadOnlySpan<byte> pattern = Encoding.ASCII.GetBytes("PLAYER_1");
            Span<byte> buffer = new byte[1024];

            while (stream.Read(buffer) > 0)
            {
                int idx = buffer.IndexOf(pattern);
                if (idx > -1)
                {
                    idx += pattern.Length;
                    // rewind unused buffer
                    stream.Position -= buffer.Length - idx;
                    return idx;
                }
            }

            return -1;
        }
    }
}
