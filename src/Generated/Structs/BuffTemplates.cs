namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BuffTemplates
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("BuffDefinitions")]
	public TableReference BuffDefinitionsKey;

	[FieldOffset(24)]
	[ElementType(typeof(int))]
	public ArrayReference Buff_StatValues;

	[FieldOffset(40)]
	public int AuraRadius;

	[FieldOffset(44)]
	[ElementType(typeof(int))]
	public ArrayReference Unk004;

	[FieldOffset(60)]
	[ElementType(typeof(int))]
	public ArrayReference Unk005;

	[FieldOffset(76)]
	[ReferenceTable("BuffVisuals")]
	public TableReference BuffVisualsKey;

	[FieldOffset(92)]
	public float Unk007;

	[FieldOffset(96)]
	public TBool Unk008;

	[FieldOffset(97)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference StatsKey;

	[FieldOffset(113)]
	public int Unk010;

	[FieldOffset(117)]
	public int Unk011;

	[FieldOffset(121)]
	public TBool Unk012;

	[FieldOffset(122)]
	[ReferenceTable("Stats")]
	public TableReference Unk013;

}
