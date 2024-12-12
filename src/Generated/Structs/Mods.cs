namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Mods
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public short HASH16;

	[FieldOffset(10)]
	[ReferenceTable("ModType")]
	public TableReference ModTypeKey;

	[FieldOffset(26)]
	public int Level;

	[FieldOffset(30)]
	[ReferenceTable("Stats")]
	public TableReference StatsKey1;

	[FieldOffset(46)]
	[ReferenceTable("Stats")]
	public TableReference StatsKey2;

	[FieldOffset(62)]
	[ReferenceTable("Stats")]
	public TableReference StatsKey3;

	[FieldOffset(78)]
	[ReferenceTable("Stats")]
	public TableReference StatsKey4;

	[FieldOffset(94)]
	[ReferenceTable("ModDomains")]
	[EnumName("ModDomains")]
	public TEnum Domain;

	[FieldOffset(98)]
	public StringReference Name;

	[FieldOffset(106)]
	[ReferenceTable("ModGenerationType")]
	[EnumName("ModGenerationType")]
	public TEnum GenerationType;

	[FieldOffset(110)]
	[ReferenceTable("ModFamily")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Families;

	[FieldOffset(126)]
	public int Stat1Min;

	[FieldOffset(130)]
	public int Stat1Max;

	[FieldOffset(134)]
	public int Stat2Min;

	[FieldOffset(138)]
	public int Stat2Max;

	[FieldOffset(142)]
	public int Stat3Min;

	[FieldOffset(146)]
	public int Stat3Max;

	[FieldOffset(150)]
	public int Stat4Min;

	[FieldOffset(154)]
	public int Stat4Max;

	[FieldOffset(158)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TableReference))]
	public ArrayReference SpawnWeight_TagsKeys;

	[FieldOffset(174)]
	[ElementType(typeof(int))]
	public ArrayReference SpawnWeight_Values;

	[FieldOffset(190)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TableReference))]
	public ArrayReference TagsKeys;

	[FieldOffset(206)]
	[ReferenceTable("GrantedEffectsPerLevel")]
	[ElementType(typeof(TableReference))]
	public ArrayReference GrantedEffectsPerLevelKeys;

	[FieldOffset(222)]
	[ElementType(typeof(int))]
	public ArrayReference Unk024;

	[FieldOffset(238)]
	public StringReference MonsterMetadata;

	[FieldOffset(246)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference MonsterKillAchievements;

	[FieldOffset(262)]
	[ReferenceTable("ModType")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ChestModType;

	[FieldOffset(278)]
	public int Stat5Min;

	[FieldOffset(282)]
	public int Stat5Max;

	[FieldOffset(286)]
	[ReferenceTable("Stats")]
	public TableReference StatsKey5;

	[FieldOffset(302)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference FullAreaClear_AchievementItemsKey;

	[FieldOffset(318)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference AchievementItemsKey;

	[FieldOffset(334)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TableReference))]
	public ArrayReference GenerationWeight_TagsKeys;

	[FieldOffset(350)]
	[ElementType(typeof(int))]
	public ArrayReference GenerationWeight_Values;

	[FieldOffset(366)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ModifyMapsAchievements;

	[FieldOffset(382)]
	public TBool IsEssenceOnlyModifier;

	[FieldOffset(383)]
	public int Stat6Min;

	[FieldOffset(387)]
	public int Stat6Max;

	[FieldOffset(391)]
	[ReferenceTable("Stats")]
	public TableReference StatsKey6;

	[FieldOffset(407)]
	public int MaxLevel;

	[FieldOffset(411)]
	public TBool Unk041;

	[FieldOffset(412)]
	[ReferenceTable("ItemClasses")]
	[ElementType(typeof(TableReference))]
	public ArrayReference CraftingItemClassRestrictions;

	[FieldOffset(428)]
	public StringReference MonsterOnDeath;

	[FieldOffset(436)]
	public int Unk044;

	[FieldOffset(440)]
	[ReferenceTable("GrantedEffectsPerLevel")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk045;

	[FieldOffset(456)]
	public int Heist_SubStatValue1;

	[FieldOffset(460)]
	public int Heist_SubStatValue2;

	[FieldOffset(464)]
	[ReferenceTable("Stats")]
	public TableReference Heist_StatsKey0;

	[FieldOffset(480)]
	[ReferenceTable("Stats")]
	public TableReference Heist_StatsKey1;

	[FieldOffset(496)]
	public int Heist_AddStatValue1;

	[FieldOffset(500)]
	public int Heist_AddStatValue2;

	[FieldOffset(504)]
	[ReferenceTable("InfluenceTypes")]
	[EnumName("InfluenceTypes")]
	public TEnum InfluenceTypes;

	[FieldOffset(508)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ImplicitTagsKeys;

	[FieldOffset(524)]
	public TBool Unk054;

	[FieldOffset(525)]
	public int Unk055;

	[FieldOffset(529)]
	public int Unk056;

	[FieldOffset(533)]
	public int Unk057;

	[FieldOffset(537)]
	public int Unk058;

	[FieldOffset(541)]
	public int Unk059;

	[FieldOffset(545)]
	public int Unk060;

	[FieldOffset(549)]
	public int Unk061;

	[FieldOffset(553)]
	public int Unk062;

	[FieldOffset(557)]
	public int Unk063;

	[FieldOffset(561)]
	public int Unk064;

	[FieldOffset(565)]
	public int Unk065;

	[FieldOffset(569)]
	public int Unk066;

	[FieldOffset(573)]
	public int Unk067;

	[FieldOffset(577)]
	public int Unk068;

	[FieldOffset(581)]
	public int Unk069;

	[FieldOffset(585)]
	public int Unk070;

	[FieldOffset(589)]
	[ReferenceTable("BuffTemplates")]
	public TableReference BuffTemplate;

	[FieldOffset(605)]
	[ReferenceTable("Mods")]
	public TableReference ArchnemesisMinionMod;

	[FieldOffset(613)]
	public int HASH32;

	[FieldOffset(617)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk074;

	[FieldOffset(633)]
	public int Unk075;

	[FieldOffset(637)]
	[ReferenceTable("GrantedEffectsPerLevel")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk076;

}
