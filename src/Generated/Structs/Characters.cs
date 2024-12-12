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

	[FieldOffset(120)]
	public TableReference Unk018;

	[FieldOffset(136)]
	public int Unk019;

	[FieldOffset(140)]
	public int Unk020;

	[FieldOffset(144)]
	public int CharacterSize;

	[FieldOffset(148)]
	public StringReference IntroSoundFile;

	[FieldOffset(156)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference StartWeapons;

	[FieldOffset(172)]
	public StringReference Gender;

	[FieldOffset(180)]
	public StringReference TraitDescription;

	[FieldOffset(188)]
	public TableReference Unk026;

	[FieldOffset(204)]
	public TableReference Unk027;

	[FieldOffset(220)]
	public TableReference Unk028;

	[FieldOffset(236)]
	public TableReference Unk029;

	[FieldOffset(252)]
	public int Unk030;

	[FieldOffset(256)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk031;

	[FieldOffset(272)]
	public StringReference PassiveTreeImage;

	[FieldOffset(280)]
	public int Unk033;

	[FieldOffset(284)]
	public int Unk034;

	[FieldOffset(288)]
	public StringReference TencentVideo;

	[FieldOffset(296)]
	public StringReference AttrsAsId;

	[FieldOffset(304)]
	public StringReference LoginScreen;

	[FieldOffset(312)]
	public StringReference PlayerCritter;

	[FieldOffset(320)]
	public StringReference PlayerEffect;

	[FieldOffset(328)]
	public StringReference AfterImage;

	[FieldOffset(336)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference Mirage;

	[FieldOffset(352)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference CloneImmobile;

	[FieldOffset(368)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference ReplicateClone;

	[FieldOffset(384)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference LightningClone;

	[FieldOffset(400)]
	public float Unk045;

	[FieldOffset(404)]
	public float Unk046;

	[FieldOffset(408)]
	public StringReference SkillTreeBackground;

	[FieldOffset(416)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference Clone;

	[FieldOffset(432)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference Double;

	[FieldOffset(448)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference MirageWarrior;

	[FieldOffset(464)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference DoubleTwo;

	[FieldOffset(480)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference DarkExile;

	[FieldOffset(496)]
	public StringReference Attr;

	[FieldOffset(504)]
	public StringReference AttrLowercase;

	[FieldOffset(512)]
	public StringReference Script;

	[FieldOffset(520)]
	public TableReference Unk056;

	[FieldOffset(536)]
	public int Unk057;

	[FieldOffset(540)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference Unk058;

	[FieldOffset(556)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference Unk059;

	[FieldOffset(572)]
	public int Unk060;

	[FieldOffset(576)]
	public float Unk061;

}
