namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistNPCs
{
	[FieldOffset(0)]
	[ReferenceTable("NPCs")]
	public TableReference NPCsKey;

	[FieldOffset(16)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference MonsterVarietiesKey;

	[FieldOffset(32)]
	[ReferenceTable("HeistJobs")]
	[ElementType(typeof(TableReference))]
	public ArrayReference SkillLevel_HeistJobsKeys;

	[FieldOffset(48)]
	public StringReference PortraitFile;

	[FieldOffset(56)]
	[ReferenceTable("HeistNPCStats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference HeistNPCStatsKeys;

	[FieldOffset(72)]
	[ElementType(typeof(float))]
	public ArrayReference StatValues;

	[FieldOffset(88)]
	public float Unk006;

	[FieldOffset(92)]
	[ElementType(typeof(int))]
	public ArrayReference SkillLevel_Values;

	[FieldOffset(108)]
	public StringReference Name;

	[FieldOffset(116)]
	public StringReference SilhouetteFile;

	[FieldOffset(124)]
	public int Unk010;

	[FieldOffset(128)]
	public int Unk011;

	[FieldOffset(132)]
	[ReferenceTable("HeistNPCs")]
	public TableReference HeistNPCsKey;

	[FieldOffset(140)]
	[ElementType(typeof(float))]
	public ArrayReference StatValues2;

	[FieldOffset(156)]
	[ReferenceTable("NPCs")]
	public TableReference Ally_NPCsKey;

	[FieldOffset(172)]
	public StringReference ActiveNPCIcon;

	[FieldOffset(180)]
	[ReferenceTable("HeistJobs")]
	public TableReference HeistJobsKey;

	[FieldOffset(196)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Equip_AchievementItemsKeys;

	[FieldOffset(212)]
	public StringReference AOFile;

	[FieldOffset(220)]
	public TableReference Unk019;

}
