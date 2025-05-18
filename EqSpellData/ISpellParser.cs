using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace EqSpellData
{
    public interface ISpellParser : IDisposable
    {
        ConcurrentDictionary<int, SpellData> Spells { get; }
        SpellFileFormat Format { get; }
        void Parse();
        Task ParseAsync();
    }
}
