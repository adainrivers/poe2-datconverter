namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct FixedHideoutDoodadTypes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("HideoutDoodads")]
	[ElementType(typeof(TableReference))]
	public ArrayReference HideoutDoodadsKeys;

	[FieldOffset(24)]
	[ReferenceTable("HideoutDoodads")]
	public TableReference BaseTypeHideoutDoodadsKey;

	[FieldOffset(40)]
	public int Unk003;

	[FieldOffset(44)]
	public int Unk004;

	[FieldOffset(48)]
	public TBool Unk005;

	[FieldOffset(49)]
	public TableReference Unk006;

	[FieldOffset(65)]
	public int Unk007;

	[FieldOffset(69)]
	public TableReference Unk008;

}
