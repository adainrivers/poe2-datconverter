namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Characters
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Name;

	[FieldOffset(16)]
	public StringReference AOFile;

	[FieldOffset(24)]
	public StringReference ACTFile;

	[FieldOffset(32)]
	public int BaseMaxLife;

	[FieldOffset(36)]
	public int BaseMaxMana;

	[FieldOffset(40)]
	public int WeaponSpeed;

	[FieldOffset(44)]
	public int MinDamage;

	[FieldOffset(48)]
	public int MaxDamage;

	[FieldOffset(52)]
	public int MaxAttackDistance;

	[FieldOffset(56)]
	public StringReference Icon;

	[FieldOffset(64)]
	public int IntegerId;

	[FieldOffset(68)]
	public int BaseStrength;

	[FieldOffset(72)]
	public int BaseDexterity;

	[FieldOffset(76)]
	public int BaseIntelligence;

	[FieldOffset(80)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk015;

	[FieldOffset(96)]
	public StringReference Description;

	[FieldOffset(104)]
	[ReferenceTable("SkillGems")]
	public TableReference StartSkillGem;

	//[FieldOffset(120)]
	//public TableReference Unk018;

	[FieldOffset(136)]
    public int Unk019;


	[FieldOffset(152)]
	public int Unk20;

    [FieldOffset(156)]
    public int Unk21;

    [FieldOffset(160)]
    public StringReference IntroSoundFile;

    //[FieldOffset(156)]
    //[ReferenceTable("BaseItemTypes")]
    //[ElementType(typeof(TableReference))]
    //public ArrayReference StartWeapons;

    [FieldOffset(168)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference StartWeapons;

    [FieldOffset(184)]
    public StringReference Gender;

    [FieldOffset(192)]
	public StringReference TraitDescription;

	[FieldOffset(200)]
	public TableReference Unk027;

	[FieldOffset(216)]
	public TableReference Unk028;

	[FieldOffset(232)]
	public long Unk029;

    [FieldOffset(240)]
    public StringReference PassiveTreeImage;

    [FieldOffset(248)]
    public TableReference Unk030;

    [FieldOffset(264)]
	public TableReference Unk031;

	[FieldOffset(280)]
	public int Unk033;

	[FieldOffset(284)]
	public StringReference PassiveTreeImageAgain;

	[FieldOffset(292)]
	public StringReference TencentVideo;

	[FieldOffset(300)]
	public StringReference AttrsAsId;

	[FieldOffset(308)]
	public StringReference LoginScreen;

	[FieldOffset(316)]
	public StringReference PlayerCritter;

	[FieldOffset(324)]
	public StringReference PlayerEffect;

	[FieldOffset(332)]
	public StringReference AfterImage;

	[FieldOffset(340)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference Mirage;

	[FieldOffset(356)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference CloneImmobile;

	[FieldOffset(372)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference ReplicateClone;

	[FieldOffset(388)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference LightningClone;

	[FieldOffset(404)]
	public float Unk045;

	[FieldOffset(408)]
	public float Unk046;

	[FieldOffset(412)]
	public StringReference SkillTreeBackground;

	[FieldOffset(420)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference Clone;

	[FieldOffset(436)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference Double;

	[FieldOffset(454)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference MirageWarrior;

	[FieldOffset(468)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference DoubleTwo;

	[FieldOffset(484)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference DarkExile;

	[FieldOffset(500)]
	public StringReference Attr;

	[FieldOffset(508)]
	public StringReference AttrLowercase;

	[FieldOffset(516)]
	public StringReference Script;

	[FieldOffset(524)]
	public TableReference Unk056;

	[FieldOffset(540)]
	public int Unk057;

	[FieldOffset(544)]
	public float Unk058;

    [FieldOffset(548)]
    public float Unk059;

	[FieldOffset(552)]
    public float Unk060;

	[FieldOffset(556)]
    public long Unk061;

    [FieldOffset(564)]
	public int Unk062;

    [FieldOffset(568)]
	public TableReference Unk063;

    [FieldOffset(584)]
	public long Unk064;
    
    [FieldOffset(592)]
	public long Unk065;
    
    [FieldOffset(600)]
    public float Unk066;

    [FieldOffset(604)]
	public long Unk067;

}
