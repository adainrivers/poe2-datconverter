namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LabyrinthAreas
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("WorldAreas")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Normal_WorldAreasKeys;

	[FieldOffset(24)]
	[ReferenceTable("WorldAreas")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Cruel_WorldAreasKeys;

	[FieldOffset(40)]
	[ReferenceTable("WorldAreas")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Merciless_WorldAreasKeys;

	[FieldOffset(56)]
	[ReferenceTable("WorldAreas")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Endgame_WorldAreasKeys;

	[FieldOffset(72)]
	public int Unk005;

}
