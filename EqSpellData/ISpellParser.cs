using System.Collections.Concurrent;

namespace EqSpellData;
public interface ISpellParser : IDisposable
{
    ConcurrentDictionary<int, SpellData> Spells { get; }
    SpellFileFormat Format { get; }
    void Parse();
    Task ParseAsync();
}
