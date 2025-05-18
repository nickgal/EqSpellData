using System.IO;

namespace EqSpellData
{
    public class BinarySpellReader : ISpellReader
    {
        private readonly SpellFileFormat _spellFileFormat;

        private bool Binary608 => _spellFileFormat == SpellFileFormat.Binary608;

        public BinarySpellReader(SpellFileFormat spellFileFormat)
        {
            _spellFileFormat = spellFileFormat;
        }

        public SpellData? ParseBytes(BinaryReader br)
        {
            var spell = new SpellData();
            spell.SpellName = br.ReadSzString(32);
            spell.ActorTag = br.ReadSzString(32);
            spell.NpcFilename = br.ReadSzString(32);
            spell.CasterMeTxt = br.ReadSzString(64);
            spell.CasterOtherTxt = br.ReadSzString(64);
            spell.CastedMeTxt = br.ReadSzString(64);
            spell.CastedOtherTxt = br.ReadSzString(64);
            spell.SpellGone = br.ReadSzString(64);
            spell.Range = br.ReadSingle();
            spell.ImpactRadius = br.ReadSingle();
            spell.OutForce = br.ReadSingle();
            spell.UpForce = br.ReadSingle();
            spell.CastingTime = br.ReadUInt32();
            spell.RecoveryDelay = br.ReadUInt32();
            spell.SpellDelay = br.ReadUInt32();
            spell.DurationBase = br.ReadUInt32();
            spell.DurationCap = br.ReadUInt32();
            spell.ImpactDuration = br.ReadUInt32();
            spell.ManaCost = br.ReadUInt16();
            spell.BaseAffect1 = br.ReadInt16();
            spell.BaseAffect2 = br.ReadInt16();
            spell.BaseAffect3 = br.ReadInt16();
            spell.BaseAffect4 = br.ReadInt16();
            if (Binary608)
            {
                spell.BaseAffect5 = br.ReadInt16();
                spell.BaseAffect6 = br.ReadInt16();
                spell.BaseAffect7 = br.ReadInt16();
                spell.BaseAffect8 = br.ReadInt16();
                spell.BaseAffect9 = br.ReadInt16();
                spell.BaseAffect10 = br.ReadInt16();
                spell.BaseAffect11 = br.ReadInt16();
                spell.BaseAffect12 = br.ReadInt16();
            }
            spell.Affect1Cap = br.ReadInt16();
            spell.Affect2Cap = br.ReadInt16();
            spell.Affect3Cap = br.ReadInt16();
            spell.Affect4Cap = br.ReadInt16();
            if (Binary608)
            {
                spell.Affect5Cap = br.ReadInt16();
                spell.Affect6Cap = br.ReadInt16();
                spell.Affect7Cap = br.ReadInt16();
                spell.Affect8Cap = br.ReadInt16();
                spell.Affect9Cap = br.ReadInt16();
                spell.Affect10Cap = br.ReadInt16();
                spell.Affect11Cap = br.ReadInt16();
                spell.Affect12Cap = br.ReadInt16();
            }
            spell.ImageNumber = br.ReadInt16();
            spell.MemImageNumber = br.ReadInt16();
            spell.ExpendReagent1 = br.ReadInt16();
            spell.ExpendReagent2 = br.ReadInt16();
            spell.ExpendReagent3 = br.ReadInt16();
            spell.ExpendReagent4 = br.ReadInt16();
            spell.ExpendQty1 = br.ReadInt16();
            spell.ExpendQty2 = br.ReadInt16();
            spell.ExpendQty3 = br.ReadInt16();
            spell.ExpendQty4 = br.ReadInt16();
            spell.NoExpendReagent1 = br.ReadInt16();
            spell.NoExpendReagent2 = br.ReadInt16();

            spell.LevelAffect1Mod = br.ReadByte();
            spell.LevelAffect2Mod = br.ReadByte();
            spell.LevelAffect3Mod = br.ReadByte();
            spell.LevelAffect4Mod = br.ReadByte();
            if (Binary608)
            {
                spell.LevelAffect5Mod = br.ReadByte();
                spell.LevelAffect6Mod = br.ReadByte();
                spell.LevelAffect7Mod = br.ReadByte();
                spell.LevelAffect8Mod = br.ReadByte();
                spell.LevelAffect9Mod = br.ReadByte();
                spell.LevelAffect10Mod = br.ReadByte();
                spell.LevelAffect11Mod = br.ReadByte();
                spell.LevelAffect12Mod = br.ReadByte();
            }
            spell.LightType = br.ReadByte();
            spell.Beneficial = br.ReadSByte();
            spell.Activated = br.ReadByte();
            spell.ResistType = br.ReadByte();
            spell.SpellAffect1 = br.ReadByte();
            spell.SpellAffect2 = br.ReadByte();
            spell.SpellAffect3 = br.ReadByte();
            spell.SpellAffect4 = br.ReadByte();
            if (Binary608)
            {
                spell.SpellAffect5 = br.ReadByte();
                spell.SpellAffect6 = br.ReadByte();
                spell.SpellAffect7 = br.ReadByte();
                spell.SpellAffect8 = br.ReadByte();
                spell.SpellAffect9 = br.ReadByte();
                spell.SpellAffect10 = br.ReadByte();
                spell.SpellAffect11 = br.ReadByte();
                spell.SpellAffect12 = br.ReadByte();
            }
            spell.TypeNumber = br.ReadByte();
            spell.BaseDifficulty = br.ReadByte();
            spell.CastingSkill = br.ReadByte();
            spell.ZoneType = br.ReadSByte();
            spell.EnvironmentType = br.ReadSByte();
            spell.TimeOfDay = br.ReadSByte();
            var unkClass = br.ReadByte(); // DefaultClass?
            spell.WarriorMin = br.ReadByte();
            spell.ClericMin = br.ReadByte();
            spell.PaladinMin = br.ReadByte();
            spell.RangerMin = br.ReadByte();
            spell.ShadowKnightMin = br.ReadByte();
            spell.DruidMin = br.ReadByte();
            spell.MonkMin = br.ReadByte();
            spell.BardMin = br.ReadByte();
            spell.RogueMin = br.ReadByte();
            spell.ShamanMin = br.ReadByte();
            spell.NecromancerMin = br.ReadByte();
            spell.WizardMin = br.ReadByte();
            spell.MagicianMin = br.ReadByte();
            spell.EnchanterMin = br.ReadByte();
            spell.BeastlordMin = br.ReadByte();
            var unk = br.ReadBytes(14);
            spell.CastingAnim = br.ReadByte();
            spell.TargetAnim = br.ReadByte();
            spell.TravelType = br.ReadUInt32();
            var unk2 = br.ReadBytes(4);
            spell.SpellAffectIndex = br.ReadInt32();

            // if (unk.Any(u => u > 0) || unk2.Any(u => u > 0))
            // {
            //     Console.WriteLine("unk binary value found");
            // }

            return spell;
        }
    }
}
