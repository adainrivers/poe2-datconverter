namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AddBuffToTargetVarieties
{
	[FieldOffset(0)]
	[ReferenceTable("BuffDefinitions")]
	public TableReference BuffDefinitions;

	[FieldOffset(16)]
	[ElementType(typeof(int))]
	public ArrayReference Unk001;

	[FieldOffset(32)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference StatsKeys;

	[FieldOffset(48)]
	public int Unk003;

	[FieldOffset(52)]
	[ElementType(typeof(int))]
	public ArrayReference Unk004;

	[FieldOffset(68)]
	public int Unk005;

	[FieldOffset(72)]
	public int Unk006;

	[FieldOffset(76)]
	[ElementType(typeof(int))]
	public ArrayReference Unk007;

}
