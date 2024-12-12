namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LegionMonsterVarieties
{
	[FieldOffset(0)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference MonsterVarietiesKey;

	[FieldOffset(16)]
	[ReferenceTable("LegionFactions")]
	public TableReference LegionFactionsKey;

	[FieldOffset(32)]
	[ReferenceTable("LegionRanks")]
	public TableReference LegionRanksKey;

	[FieldOffset(48)]
	public int Unk003;

	[FieldOffset(52)]
	[ReferenceTable("MiscAnimated")]
	[ElementType(typeof(TableReference))]
	public ArrayReference MiscAnimatedKey;

	[FieldOffset(68)]
	public int Unk005;

	[FieldOffset(72)]
	public int Unk006;

	[FieldOffset(76)]
	[ElementType(typeof(int))]
	public ArrayReference Unk007;

	[FieldOffset(92)]
	[ElementType(typeof(int))]
	public ArrayReference Unk008;

	[FieldOffset(108)]
	[ElementType(typeof(int))]
	public ArrayReference Unk009;

	[FieldOffset(124)]
	[ElementType(typeof(int))]
	public ArrayReference Unk010;

	[FieldOffset(140)]
	[ElementType(typeof(int))]
	public ArrayReference Unk011;

	[FieldOffset(156)]
	[ElementType(typeof(int))]
	public ArrayReference Unk012;

	[FieldOffset(172)]
	public int Unk013;

	[FieldOffset(176)]
	public int Unk014;

	[FieldOffset(180)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk015;

	[FieldOffset(196)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference MonsterVarietiesKey2;

}
