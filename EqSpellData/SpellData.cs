namespace EqSpellData;
public class SpellData
{
    private const int NoSpellAffect = 254;

    // SPELLINDEX
    public int SpellIndex { get; set; }

    // SPELLNAME
    public string SpellName { get; set; } = string.Empty;

    // ACTORTAG
    public string ActorTag { get; set; } = string.Empty;

    // NPC_FILENAME
    public string NpcFilename { get; set; } = string.Empty;

    // CASTERMETXT
    public string CasterMeTxt { get; set; } = string.Empty;

    // CASTEROTHERTXT
    public string CasterOtherTxt { get; set; } = string.Empty;

    // CASTEDMETXT
    public string CastedMeTxt { get; set; } = string.Empty;

    // CASTEDOTHERTXT
    public string CastedOtherTxt { get; set; } = string.Empty;

    // SPELLGONE
    public string SpellGone { get; set; } = string.Empty;

    // RANGE
    public float Range { get; set; }

    // IMPACTRADIUS
    public float ImpactRadius { get; set; }

    // OUTFORCE
    public float OutForce { get; set; }

    // UPFORCE
    public float UpForce { get; set; }

    // CASTINGTIME
    public uint CastingTime { get; set; }

    // RECOVERYDELAY
    public uint RecoveryDelay { get; set; }

    // SPELLDELAY
    public uint SpellDelay { get; set; }

    // DURATIONBASE
    public uint DurationBase { get; set; }

    // DURATIONCAP
    public uint DurationCap { get; set; }

    // IMPACTDURATION
    public uint ImpactDuration { get; set; }

    // MANACOST
    public ushort ManaCost { get; set; }

    // BASEAFFECT1
    public int BaseAffect1 { get; set; }

    // BASEAFFECT2
    public int BaseAffect2 { get; set; }

    // BASEAFFECT3
    public int BaseAffect3 { get; set; }

    // BASEAFFECT4
    public int BaseAffect4 { get; set; }

    // BASEAFFECT5
    public int BaseAffect5 { get; set; }

    // BASEAFFECT6
    public int BaseAffect6 { get; set; }

    // BASEAFFECT7
    public int BaseAffect7 { get; set; }

    // BASEAFFECT8
    public int BaseAffect8 { get; set; }

    // BASEAFFECT9
    public int BaseAffect9 { get; set; }

    // BASEAFFECT10
    public int BaseAffect10 { get; set; }

    // BASEAFFECT11
    public int BaseAffect11 { get; set; }

    // BASEAFFECT12
    public int BaseAffect12 { get; set; }

    // AFFECT1CAP
    public int Affect1Cap { get; set; }

    // AFFECT2CAP
    public int Affect2Cap { get; set; }

    // AFFECT3CAP
    public int Affect3Cap { get; set; }

    // AFFECT4CAP
    public int Affect4Cap { get; set; }

    // AFFECT5CAP
    public int Affect5Cap { get; set; }

    // AFFECT6CAP
    public int Affect6Cap { get; set; }

    // AFFECT7CAP
    public int Affect7Cap { get; set; }

    // AFFECT8CAP
    public int Affect8Cap { get; set; }

    // AFFECT9CAP
    public int Affect9Cap { get; set; }

    // AFFECT10CAP
    public int Affect10Cap { get; set; }

    // AFFECT11CAP
    public int Affect11Cap { get; set; }

    // AFFECT12CAP
    public int Affect12Cap { get; set; }

    // IMAGENUMBER
    public short ImageNumber { get; set; }

    // MEMIMAGENUMBER
    public short MemImageNumber { get; set; }

    // EXPENDREAGENT1
    public int ExpendReagent1 { get; set; }

    // EXPENDREAGENT2
    public int ExpendReagent2 { get; set; }

    // EXPENDREAGENT3
    public int ExpendReagent3 { get; set; }

    // EXPENDREAGENT4
    public int ExpendReagent4 { get; set; }

    // EXPENDQTY1
    public int ExpendQty1 { get; set; }

    // EXPENDQTY2
    public int ExpendQty2 { get; set; }

    // EXPENDQTY3
    public int ExpendQty3 { get; set; }

    // EXPENDQTY4
    public int ExpendQty4 { get; set; }

    // NOEXPENDREAGENT1
    public int NoExpendReagent1 { get; set; } = -1;

    // NOEXPENDREAGENT2
    public int NoExpendReagent2 { get; set; } = -1;

    // NOEXPENDREAGENT3
    public int NoExpendReagent3 { get; set; } = -1;

    // NOEXPENDREAGENT4
    public int NoExpendReagent4 { get; set; } = -1;

    // LEVELAFFECT1MOD
    public short LevelAffect1Mod { get; set; }

    // LEVELAFFECT2MOD
    public short LevelAffect2Mod { get; set; }

    // LEVELAFFECT3MOD
    public short LevelAffect3Mod { get; set; }

    // LEVELAFFECT4MOD
    public short LevelAffect4Mod { get; set; }

    // LEVELAFFECT5MOD
    public short LevelAffect5Mod { get; set; }

    // LEVELAFFECT6MOD
    public short LevelAffect6Mod { get; set; }

    // LEVELAFFECT7MOD
    public short LevelAffect7Mod { get; set; }

    // LEVELAFFECT8MOD
    public short LevelAffect8Mod { get; set; }

    // LEVELAFFECT9MOD
    public short LevelAffect9Mod { get; set; }

    // LEVELAFFECT10MOD
    public short LevelAffect10Mod { get; set; }

    // LEVELAFFECT11MOD
    public short LevelAffect11Mod { get; set; }

    // LEVELAFFECT12MOD
    public short LevelAffect12Mod { get; set; }

    // LIGHTTYPE
    public int LightType { get; set; }

    // BENEFICIAL
    public sbyte Beneficial { get; set; }

    // ACTIVATED
    public int Activated { get; set; }

    // RESISTTYPE
    public int ResistType { get; set; }

    // SPELLAFFECT1
    public int SpellAffect1 { get; set; } = NoSpellAffect;

    // SPELLAFFECT2
    public int SpellAffect2 { get; set; } = NoSpellAffect;

    // SPELLAFFECT3
    public int SpellAffect3 { get; set; } = NoSpellAffect;

    // SPELLAFFECT4
    public int SpellAffect4 { get; set; } = NoSpellAffect;

    // SPELLAFFECT5
    public int SpellAffect5 { get; set; } = NoSpellAffect;

    // SPELLAFFECT6
    public int SpellAffect6 { get; set; } = NoSpellAffect;

    // SPELLAFFECT7
    public int SpellAffect7 { get; set; } = NoSpellAffect;

    // SPELLAFFECT8
    public int SpellAffect8 { get; set; } = NoSpellAffect;

    // SPELLAFFECT9
    public int SpellAffect9 { get; set; } = NoSpellAffect;

    // SPELLAFFECT10
    public int SpellAffect10 { get; set; } = NoSpellAffect;

    // SPELLAFFECT11
    public int SpellAffect11 { get; set; } = NoSpellAffect;

    // SPELLAFFECT12
    public int SpellAffect12 { get; set; } = NoSpellAffect;

    // TYPENUMBER
    public int TypeNumber { get; set; }

    // BASEDIFFICULTY
    public int BaseDifficulty { get; set; }

    // CASTINGSKILL
    public int CastingSkill { get; set; }

    // ZONETYPE
    public int ZoneType { get; set; }

    // ENVIRONMENTTYPE
    public int EnvironmentType { get; set; }

    // TIMEOFDAY
    public int TimeOfDay { get; set; }

    // WARRIORMIN
    public byte WarriorMin { get; set; }

    // CLERICMIN
    public byte ClericMin { get; set; }

    // PALADINMIN
    public byte PaladinMin { get; set; }

    // RANGERMIN
    public byte RangerMin { get; set; }

    // SHADOWKNIGHTMIN
    public byte ShadowKnightMin { get; set; }

    // DRUIDMIN
    public byte DruidMin { get; set; }

    // MONKMIN
    public byte MonkMin { get; set; }

    // BARDMIN
    public byte BardMin { get; set; }

    // ROGUEMIN
    public byte RogueMin { get; set; }

    // SHAMANMIN
    public byte ShamanMin { get; set; }

    // NECROMANCERMIN
    public byte NecromancerMin { get; set; }

    // WIZARDMIN
    public byte WizardMin { get; set; }

    // MAGICIANMIN
    public byte MagicianMin { get; set; }

    // ENCHANTERMIN
    public byte EnchanterMin { get; set; }

    // BEASTLORDMIN
    public byte BeastlordMin { get; set; }

    // CASTINGANIM
    public byte CastingAnim { get; set; }

    // TARGETANIM
    public byte TargetAnim { get; set; }

    // TRAVELTYPE
    public uint TravelType { get; set; }

    // SPELLAFFECTINDEX
    public int SpellAffectIndex { get; set; }

    // CANCELONSIT
    public sbyte CancelOnSit { get; set; }

    // DIETY_AGNOSTIC
    public sbyte DietyAgnostic { get; set; }

    // DIETY_BERTOXXULOUS
    public sbyte DietyBertoxxulous { get; set; }

    // DIETY_BRELLSERILIS
    public sbyte DietyBrellSerilis { get; set; }

    // DIETY_CAZICTHULE
    public sbyte DietyCazicThule { get; set; }

    // DIETY_EROLLISIMARR
    public sbyte DietyErollisimarr { get; set; }

    // DIETY_FIZZLETHORP
    public sbyte DietyFizzlethorp { get; set; }

    // DIETY_INNORUUK
    public sbyte DietyInnoruuk { get; set; }

    // DIETY_KARANA
    public sbyte DietyKarana { get; set; }

    // DIETY_MITHMARR
    public sbyte DietyMithmarr { get; set; }

    // DIETY_PREXUS
    public sbyte DietyPrexus { get; set; }

    // DIETY_QUELLIOUS
    public sbyte DietyQuellious { get; set; }

    // DIETY_RALLOSZEK
    public sbyte DietyRalloszek { get; set; }

    // DIETY_RODCETNIFE
    public sbyte DietyRodcetnife { get; set; }

    // DIETY_SOLUSEKRO
    public sbyte DietySolusekro { get; set; }

    // DIETY_TRIBUNAL
    public sbyte DietyTribunal { get; set; }

    // DIETY_TUNARE
    public sbyte DietyTunare { get; set; }

    // DIETY_VEESHAN
    public sbyte DietyVeeshan { get; set; }

    // NPC_NO_CAST
    public sbyte NpcNoCast { get; set; }

    // AI_PT_BONUS
    public sbyte AiPtBonus { get; set; }

    // NEW_ICON
    public short NewIcon { get; set; }

    // SPELL_EFFECT_INDEX
    public short SpellEffectIndex { get; set; }

    // NO_INTERRUPT
    public sbyte NoInterrupt { get; set; }

    // RESIST_MOD
    public short ResistMod { get; set; }

    // NOT_STACKABLE_DOT
    public sbyte NotStackableDot { get; set; }

    // DELETE_OK
    public int DeleteOk { get; set; }

    // REFLECT_SPELLINDEX
    public ushort ReflectSpellIndex { get; set; }

    // NO_PARTIAL_SAVE
    public sbyte NoPartialSave { get; set; }

    // SMALL_TARGETS_ONLY
    public sbyte SmallTargetsOnly { get; set; }

    // USES_PERSISTENT_PARTICLES
    public sbyte UsesPersistentParticles { get; set; }

    // BARD_BUFF_BOX
    public sbyte BardBuffBox { get; set; }

    // DESCRIPTION_INDEX
    public int DescriptionIndex { get; set; }

    // PRIMARY_CATEGORY
    public int PrimaryCategory { get; set; }

    // SECONDARY_CATEGORY_1
    public int SecondaryCategory1 { get; set; }

    // SECONDARY_CATEGORY_2
    public int SecondaryCategory2 { get; set; }

    // NO_NPC_LOS
    public sbyte NoNpcLos { get; set; }
}
