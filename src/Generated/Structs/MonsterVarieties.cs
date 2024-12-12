namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterVarieties
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("MonsterTypes")]
	public TableReference MonsterTypesKey;

	[FieldOffset(24)]
	public int Unk002;

	[FieldOffset(28)]
	public int ObjectSize;

	[FieldOffset(32)]
	public int MinimumAttackDistance;

	[FieldOffset(36)]
	public int MaximumAttackDistance;

	[FieldOffset(40)]
	[ElementType(typeof(StringReference))]
	public ArrayReference ACTFiles;

	[FieldOffset(56)]
	[ElementType(typeof(StringReference))]
	public ArrayReference AOFiles;

	[FieldOffset(72)]
	public StringReference BaseMonsterTypeIndex;

	[FieldOffset(80)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ModsKeys;

	[FieldOffset(96)]
	public int Unk010;

	[FieldOffset(100)]
	public StringReference Unk011;

	[FieldOffset(108)]
	public StringReference Unk012;

	[FieldOffset(116)]
	public int ModelSizeMultiplier;

	[FieldOffset(120)]
	public int Unk014;

	[FieldOffset(124)]
	public int Unk015;

	[FieldOffset(128)]
	public int Unk016;

	[FieldOffset(132)]
	public int Unk017;

	[FieldOffset(136)]
	public int Unk018;

	[FieldOffset(140)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TableReference))]
	public ArrayReference TagsKeys;

	[FieldOffset(156)]
	public int ExperienceMultiplier;

	[FieldOffset(160)]
	public int Unk021;

	[FieldOffset(164)]
	public int Unk022;

	[FieldOffset(168)]
	public int Unk023;

	[FieldOffset(172)]
	public int Unk024;

	[FieldOffset(176)]
	public int CriticalStrikeChance;

	[FieldOffset(180)]
	public int Unk026;

	[FieldOffset(184)]
	[ReferenceTable("GrantedEffects")]
	[ElementType(typeof(TableReference))]
	public ArrayReference GrantedEffectsKeys;

	[FieldOffset(200)]
	public StringReference AISFile;

	[FieldOffset(208)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ModsKeys2;

	[FieldOffset(224)]
	public StringReference Stance;

	[FieldOffset(232)]
	public TableReference Unk031;

	[FieldOffset(272)]
	public StringReference Name;

	[FieldOffset(256)]
	public int DamageMultiplier;

	[FieldOffset(260)]
	public int LifeMultiplier;

	[FieldOffset(264)]
	public int AttackSpeed;

	[FieldOffset(268)]
	[ReferenceTable("ItemVisualIdentity")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Weapon1_ItemVisualIdentityKeys;

	[FieldOffset(284)]
	[ReferenceTable("ItemVisualIdentity")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Weapon2_ItemVisualIdentityKeys;

	[FieldOffset(300)]
	[ReferenceTable("ItemVisualIdentity")]
	public TableReference Back_ItemVisualIdentityKey;

	[FieldOffset(316)]
	[ReferenceTable("ItemClasses")]
	public TableReference MainHand_ItemClassesKey;

	[FieldOffset(332)]
	[ReferenceTable("ItemClasses")]
	public TableReference OffHand_ItemClassesKey;

	[FieldOffset(348)]
	[ReferenceTable("ItemVisualIdentity")]
	public TableReference Helmet_ItemVisualIdentityKey;

	[FieldOffset(364)]
	public int Unk042;

	[FieldOffset(368)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference KillSpecificMonsterCount_AchievementItemsKeys;

	[FieldOffset(384)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Special_ModsKeys;

	//[FieldOffset(400)]
	//[ReferenceTable("AchievementItems")]
	//[ElementType(typeof(TableReference))]
	//public TArray KillRare_AchievementItemsKeys;

	[FieldOffset(416)]
	public TBool Unk046;

	[FieldOffset(417)]
	public int Unk047;

	[FieldOffset(421)]
	public int Unk048;

	[FieldOffset(425)]
	public int Unk049;

	[FieldOffset(429)]
	public int Unk050;

	[FieldOffset(433)]
	public int Unk051;

	[FieldOffset(437)]
	public int Unk052;

	[FieldOffset(441)]
	public short HASH16;

	[FieldOffset(443)]
	public TBool Unk054;

	[FieldOffset(444)]
	public StringReference Unk055;

	[FieldOffset(452)]
	[ReferenceTable("AchievementItems")]
	public TableReference KillWhileOnslaughtIsActive_AchievementItemsKey;

	[FieldOffset(468)]
	[ReferenceTable("MonsterSegments")]
	public TableReference MonsterSegmentsKey;

	[FieldOffset(484)]
	[ReferenceTable("MonsterArmours")]
	public TableReference MonsterArmoursKey;

	[FieldOffset(500)]
	[ReferenceTable("AchievementItems")]
	public TableReference KillWhileTalismanIsActive_AchievementItemsKey;

	[FieldOffset(516)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Part1_ModsKeys;

	[FieldOffset(532)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Part2_ModsKeys;

	[FieldOffset(548)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Endgame_ModsKeys;

	[FieldOffset(564)]
	public TableReference Unk063;

	[FieldOffset(580)]
	public int Unk064;

	[FieldOffset(584)]
	public int Unk065;

	[FieldOffset(588)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk066;

	[FieldOffset(604)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk067;

	[FieldOffset(620)]
	public int Unk068;

	[FieldOffset(624)]
	public StringReference SinkAnimation_AOFile;

	[FieldOffset(632)]
	public TBool Unk070;

	[FieldOffset(633)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk071;

	[FieldOffset(649)]
	public TBool Unk072;

	[FieldOffset(650)]
	public TBool Unk073;

	[FieldOffset(651)]
	public TBool Unk074;

	[FieldOffset(652)]
	public int Unk075;

	[FieldOffset(656)]
	public int Unk076;

	[FieldOffset(660)]
	public float Unk077;

	[FieldOffset(664)]
	public int Unk078;

	[FieldOffset(668)]
	public StringReference EPKFile;

	[FieldOffset(676)]
	public int Unk080;

	[FieldOffset(680)]
	[ReferenceTable("MonsterConditionalEffectPacks")]
	public TableReference MonsterConditionalEffectPacksKey;

	[FieldOffset(696)]
	public TBool Unk082;

	[FieldOffset(697)]
	public TBool Unk083;

	[FieldOffset(698)]
	public int Unk084;

	[FieldOffset(702)]
	public TBool Unk085;

	[FieldOffset(703)]
	public int Unk086;

	[FieldOffset(707)]
	public int Unk087;

	[FieldOffset(711)]
	public int Unk088;

	[FieldOffset(715)]
	public int Unk089;

	[FieldOffset(719)]
	public int Unk090;

	[FieldOffset(723)]
	public int Unk091;

	[FieldOffset(727)]
	[ElementType(typeof(StringReference))]
	public ArrayReference AddonMonsterTypeIndex;

	[FieldOffset(743)]
	public int Unk093;

	[FieldOffset(747)]
	public int Unk094;

	[FieldOffset(751)]
	public int Unk095;

	[FieldOffset(755)]
	public int Unk096;

	[FieldOffset(759)]
	public int Unk097;

	[FieldOffset(763)]
	public TBool Unk098;

	[FieldOffset(764)]
	public TBool BossHealthBar;

	[FieldOffset(765)]
	public TBool Unk100;

}
