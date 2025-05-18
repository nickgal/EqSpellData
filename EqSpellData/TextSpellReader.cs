using System;

namespace EqSpellData
{
    public class TextSpellReader : ISpellReader
    {
        public const char Delimiter = '^';

        private readonly SpellFileFormat _spellFileFormat;
        private string[] _fields = Array.Empty<string>();
        private int _fieldIndex;
        private bool Text147 => _spellFileFormat == SpellFileFormat.Text147;

        public TextSpellReader(SpellFileFormat spellFileFormat)
        {
            _spellFileFormat = spellFileFormat;
        }

        public static int GetFieldCount(ReadOnlySpan<char> line)
        {
            int fieldCount = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == Delimiter)
                    fieldCount++;
            }
            return fieldCount > 0 ? fieldCount + 1 : 0;
        }

        public SpellData? ParseLine(string line)
        {
            _fieldIndex = 0;
            _fields = line.Split(Delimiter);
            FixupFields();

            // FIXME: address invalid length entries
            if (_fields.Length != (int)_spellFileFormat)
            {
                Console.WriteLine($"Skipping {_fields.Length} - {_fields[0]} {_fields[1]}");
                return null;
            }

            var spell = new SpellData
            {
                SpellIndex = ReadInt32(),
                SpellName = ReadString(),
                ActorTag = ReadString(),
                NpcFilename = ReadString(),
                CasterMeTxt = ReadString(),
                CasterOtherTxt = ReadString(),
                CastedMeTxt = ReadString(),
                CastedOtherTxt = ReadString(),
                SpellGone = ReadString(),
                Range = ReadSingle(),
                ImpactRadius = ReadSingle(),
                OutForce = ReadSingle(),
                UpForce = ReadSingle(),
                CastingTime = ReadUInt32(),
                RecoveryDelay = ReadUInt32(),
                SpellDelay = ReadUInt32(),
                DurationBase = ReadUInt32(),
                DurationCap = ReadUInt32(),
                ImpactDuration = ReadUInt32(),
                ManaCost = ReadUInt16(),
                BaseAffect1 = ReadInt32(),
                BaseAffect2 = ReadInt32(),
                BaseAffect3 = ReadInt32(),
                BaseAffect4 = ReadInt32(),
                BaseAffect5 = ReadInt32(),
                BaseAffect6 = ReadInt32(),
                BaseAffect7 = ReadInt32(),
                BaseAffect8 = ReadInt32(),
                BaseAffect9 = ReadInt32(),
                BaseAffect10 = ReadInt32(),
                BaseAffect11 = ReadInt32(),
                BaseAffect12 = ReadInt32(),
                Affect1Cap = ReadInt32(),
                Affect2Cap = ReadInt32(),
                Affect3Cap = ReadInt32(),
                Affect4Cap = ReadInt32(),
                Affect5Cap = ReadInt32(),
                Affect6Cap = ReadInt32(),
                Affect7Cap = ReadInt32(),
                Affect8Cap = ReadInt32(),
                Affect9Cap = ReadInt32(),
                Affect10Cap = ReadInt32(),
                Affect11Cap = ReadInt32(),
                Affect12Cap = ReadInt32(),
                ImageNumber = ReadInt16(),
                MemImageNumber = ReadInt16(),
                ExpendReagent1 = ReadInt32(),
                ExpendReagent2 = ReadInt32(),
                ExpendReagent3 = ReadInt32(),
                ExpendReagent4 = ReadInt32(),
                ExpendQty1 = ReadInt32(),
                ExpendQty2 = ReadInt32(),
                ExpendQty3 = ReadInt32(),
                ExpendQty4 = ReadInt32(),
                NoExpendReagent1 = ReadInt32(),
                NoExpendReagent2 = ReadInt32(),
                NoExpendReagent3 = ReadInt32(),
                NoExpendReagent4 = ReadInt32(),
                LevelAffect1Mod = ReadInt16(),
                LevelAffect2Mod = ReadInt16(),
                LevelAffect3Mod = ReadInt16(),
                LevelAffect4Mod = ReadInt16(),
                LevelAffect5Mod = ReadInt16(),
                LevelAffect6Mod = ReadInt16(),
                LevelAffect7Mod = ReadInt16(),
                LevelAffect8Mod = ReadInt16(),
                LevelAffect9Mod = ReadInt16(),
                LevelAffect10Mod = ReadInt16(),
                LevelAffect11Mod = ReadInt16(),
                LevelAffect12Mod = ReadInt16(),
                LightType = ReadInt32(),
                Beneficial = ReadSByte(),
                Activated = ReadInt32(),
                ResistType = ReadInt32(),
                SpellAffect1 = ReadInt32(),
                SpellAffect2 = ReadInt32(),
                SpellAffect3 = ReadInt32(),
                SpellAffect4 = ReadInt32(),
                SpellAffect5 = ReadInt32(),
                SpellAffect6 = ReadInt32(),
                SpellAffect7 = ReadInt32(),
                SpellAffect8 = ReadInt32(),
                SpellAffect9 = ReadInt32(),
                SpellAffect10 = ReadInt32(),
                SpellAffect11 = ReadInt32(),
                SpellAffect12 = ReadInt32(),
                TypeNumber = ReadInt32(),
                BaseDifficulty = ReadInt32(),
                CastingSkill = ReadInt32(),
                ZoneType = ReadSByte(),
                EnvironmentType = ReadSByte(),
                TimeOfDay = ReadSByte(),
                WarriorMin = ReadByte(),
                ClericMin = ReadByte(),
                PaladinMin = ReadByte(),
                RangerMin = ReadByte(),
                ShadowKnightMin = ReadByte(),
                DruidMin = ReadByte(),
                MonkMin = ReadByte(),
                BardMin = ReadByte(),
                RogueMin = ReadByte(),
                ShamanMin = ReadByte(),
                NecromancerMin = ReadByte(),
                WizardMin = ReadByte(),
                MagicianMin = ReadByte(),
                EnchanterMin = ReadByte(),
                BeastlordMin = ReadByte(),
                CastingAnim = ReadByte(),
                TargetAnim = ReadByte(),
                TravelType = ReadUInt32(),
                SpellAffectIndex = ReadInt16(),
                CancelOnSit = ReadSByte(),
                DietyAgnostic = ReadSByte(),
                DietyBertoxxulous = ReadSByte(),
                DietyBrellSerilis = ReadSByte(),
                DietyCazicThule = ReadSByte(),
                DietyErollisimarr = ReadSByte(),
                DietyFizzlethorp = ReadSByte(),
                DietyInnoruuk = ReadSByte(),
                DietyKarana = ReadSByte(),
                DietyMithmarr = ReadSByte(),
                DietyPrexus = ReadSByte(),
                DietyQuellious = ReadSByte(),
                DietyRalloszek = ReadSByte(),
                DietyRodcetnife = ReadSByte(),
                DietySolusekro = ReadSByte(),
                DietyTribunal = ReadSByte(),
                DietyTunare = ReadSByte(),
                DietyVeeshan = ReadSByte(),
                NpcNoCast = ReadSByte(),
                AiPtBonus = ReadSByte(),
                NewIcon = ReadInt16(),
                SpellEffectIndex = ReadInt16(),
                NoInterrupt = ReadSByte(),
                ResistMod = ReadInt16(),
                NotStackableDot = ReadSByte(),
                DeleteOk = ReadInt32(),
                ReflectSpellIndex = ReadUInt16(),
                NoPartialSave = ReadSByte()
            };

            if (Text147)
            {
                spell.SmallTargetsOnly = ReadSByte();
                spell.UsesPersistentParticles = ReadSByte();
                spell.BardBuffBox = ReadSByte();
                spell.DescriptionIndex = ReadInt32();
                spell.PrimaryCategory = ReadInt32();
                spell.SecondaryCategory1 = ReadInt32();
                spell.SecondaryCategory2 = ReadInt32();
                spell.NoNpcLos = ReadSByte();
            }

            return spell;
        }

        private string NextField()
        {
            return _fields[_fieldIndex++];
        }

        private bool TryNextField(out string field)
        {
            field = NextField();
            return !string.IsNullOrWhiteSpace(field);
        }

        private string ReadString()
        {
            return NextField().Trim();
        }

        private int ReadInt32()
        {
            return TryNextField(out var field) ?  Convert.ToInt32(field) : default;
        }

        private uint ReadUInt32()
        {
            return TryNextField(out var field) ? Convert.ToUInt32(field) : default;
        }

        private short ReadInt16()
        {
            return TryNextField(out var field) ? Convert.ToInt16(field) : default;
        }

        private ushort ReadUInt16()
        {
            return TryNextField(out var field) ? Convert.ToUInt16(field) : default;
        }

        private byte ReadByte()
        {
            return TryNextField(out var field) ? Convert.ToByte(field) : default;
        }

        private sbyte ReadSByte()
        {
            return TryNextField(out var field) ? Convert.ToSByte(field) : default;
        }

        private float ReadSingle()
        {
            return TryNextField(out var field) ? Convert.ToSingle(field) : default;
        }

        private void FixupFields()
        {
            if (_fields[22].Contains('.'))
            {
                // spell 2280 has "11.03" for BaseAffect3
                _fields[22] = _fields[22].Split('.')[0];
            }
        }
    }
}
