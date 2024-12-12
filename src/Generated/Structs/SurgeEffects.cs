namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SurgeEffects
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("MiscAnimated")]
	public TableReference Unk001;

	[FieldOffset(24)]
	[ElementType(typeof(float))]
	public ArrayReference Unk002;

	[FieldOffset(40)]
	[ReferenceTable("MiscAnimated")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk003;

	[FieldOffset(56)]
	[ElementType(typeof(StringReference))]
	public ArrayReference Unk004;

}
