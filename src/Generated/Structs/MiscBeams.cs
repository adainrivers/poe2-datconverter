namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MiscBeams
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("MiscAnimated")]
	public TableReference MiscAnimated;

	[FieldOffset(24)]
	public int Unk002;

	[FieldOffset(28)]
	[ReferenceTable("PreloadGroups")]
	[ElementType(typeof(TableReference))]
	public ArrayReference PreloadGroupsKeys;

	[FieldOffset(44)]
	public int Unk004;

}
