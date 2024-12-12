namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct UltimatumModifiers
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("UltimatumModifierTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Types;

	[FieldOffset(24)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ExtraMods;

	[FieldOffset(40)]
	[ReferenceTable("UltimatumModifierTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference TypesFiltered;

	[FieldOffset(56)]
	[ReferenceTable("DaemonSpawningData")]
	public TableReference DaemonSpawningData;

	[FieldOffset(72)]
	[ReferenceTable("UltimatumModifiers")]
	public TableReference PreviousTier;

	[FieldOffset(80)]
	public TBool Unk006;

	[FieldOffset(81)]
	public int Radius;

	[FieldOffset(85)]
	public StringReference Name;

	[FieldOffset(93)]
	public StringReference Icon;

	[FieldOffset(101)]
	public int HASH16;

	[FieldOffset(105)]
	[ReferenceTable("UltimatumModifierTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference TypesExtra;

	[FieldOffset(121)]
	public int MonsterTypesApplyingRuin;

	[FieldOffset(125)]
	[ReferenceTable("MiscAnimated")]
	public TableReference MiscAnimated;

	[FieldOffset(141)]
	[ReferenceTable("BuffTemplates")]
	[ElementType(typeof(TableReference))]
	public ArrayReference BuffTemplates;

	[FieldOffset(157)]
	public int Tier;

	[FieldOffset(161)]
	public int Unk016;

	[FieldOffset(165)]
	public StringReference Description;

	[FieldOffset(173)]
	[ElementType(typeof(StringReference))]
	public ArrayReference MonsterSpawners;

	[FieldOffset(189)]
	public TBool Unk019;

	[FieldOffset(190)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Achievements;

	[FieldOffset(206)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference TextAudio;

	[FieldOffset(222)]
	[ReferenceTable("Mods")]
	public TableReference UniqueMapMod;

}
