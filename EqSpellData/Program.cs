using EqSpellData;

var path = @"C:\Apps\EQTakp\spells_en.txt";
// var path = @"C:\Code\EqSpellData\spells_en-trilogy-se-luclin.txt";
// var path = @"C:\Apps\EQBeta2\spdat.eff";
// var path = @"C:\Apps\EQTrilogy\spdat.eff";
// var path = @"C:\Code\EqSpellData\spdat-trilogy-luclin.eff";

using var spellParser = SpellParserFactory.Instance.GetSpellParser(path);
await spellParser.ParseAsync();

Console.WriteLine("Done");
