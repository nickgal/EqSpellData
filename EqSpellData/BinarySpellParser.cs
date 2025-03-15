using System.Collections.Concurrent;

namespace EqSpellData;
public class BinarySpellParser : ISpellParser
{
    public ConcurrentDictionary<int, SpellData> Spells { get; private set; } = [];
    public SpellFileFormat Format { get; private set; }

    private readonly Stream _stream;

    public BinarySpellParser(Stream stream, SpellFileFormat spellFileFormat)
    {
        _stream = stream;
        Format = spellFileFormat;
    }

    public void Parse()
    {
        int idx = 0;
        using var br = new BinaryReader(_stream);
        BinarySpellReader spellReader = new(Format);

        while (br.PeekChar() != -1)
        {
            SpellData? spell = spellReader.ParseBytes(br);
            if (spell != null)
            {
                spell.SpellIndex = idx++;
                Spells.TryAdd(spell.SpellIndex, spell);
            }
        }
    }

    public async Task ParseAsync()
    {
        await Task.Run(Parse);
    }

    public void Dispose()
    {
        _stream.Dispose();
        GC.SuppressFinalize(this);
    }
}
