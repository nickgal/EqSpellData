using System.Collections.Concurrent;

namespace EqSpellData;
public class TextSpellParser : ISpellParser
{
    public ConcurrentDictionary<int, SpellData> Spells { get; private set; } = [];
    public SpellFileFormat Format { get; private set; }

    private readonly Stream _stream;

    public TextSpellParser(Stream stream, SpellFileFormat spellFileFormat)
    {
        _stream = stream;
        Format = spellFileFormat;
    }

    public void Parse()
    {
        ParseAsync().GetAwaiter().GetResult();
    }

    public async Task ParseAsync()
    {
        using var sr = new StreamReader(_stream);
        string? line;
        List<string> lines = [];

        while ((line = await sr.ReadLineAsync().ConfigureAwait(false)) != null)
        {
            if (!string.IsNullOrWhiteSpace(line))
            {
                lines.Add(line);
            }
        }

        Parallel.ForEach(lines, l =>
        {
            TextSpellReader spellReader = new(Format);
            SpellData? spell = spellReader.ParseLine(l);
            if (spell != null)
            {
                Spells.TryAdd(spell.SpellIndex, spell);
            }
        });
    }

    public void Dispose()
    {
        _stream.Dispose();
        GC.SuppressFinalize(this);
    }
}
