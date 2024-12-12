namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BetrayalTargets
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("BetrayalRanks")]
	public TableReference BetrayalRanksKey;

	[FieldOffset(24)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference MonsterVarietiesKey;

	[FieldOffset(40)]
	[ReferenceTable("BetrayalJobs")]
	public TableReference BetrayalJobsKey;

	[FieldOffset(56)]
	public StringReference Art;

	[FieldOffset(64)]
	public TBool Unk005;

	[FieldOffset(65)]
	[ReferenceTable("ItemClasses")]
	public TableReference ItemClasses;

	[FieldOffset(81)]
	public StringReference FullName;

	[FieldOffset(89)]
	public StringReference Safehouse_ARMFile;

	[FieldOffset(97)]
	public StringReference ShortName;

	[FieldOffset(105)]
	public int Unk010;

	[FieldOffset(109)]
	[ReferenceTable("AchievementItems")]
	public TableReference SafehouseLeader_AcheivementItemsKey;

	[FieldOffset(125)]
	[ReferenceTable("AchievementItems")]
	public TableReference Level3_AchievementItemsKey;

	[FieldOffset(141)]
	public int Unk013;

	[FieldOffset(145)]
	public int Unk014;

	[FieldOffset(149)]
	public int Unk015;

	[FieldOffset(153)]
	public TableReference Unk016;

	[FieldOffset(169)]
	public StringReference ScriptArgument;

}
