namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SanctumAirlocks
{
	[FieldOffset(0)]
	[ReferenceTable("SanctumFloors")]
	public TableReference Floor;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	[ElementType(typeof(int))]
	public ArrayReference Unk002;

	[FieldOffset(36)]
	[ReferenceTable("WorldAreas")]
	public TableReference Area1;

	[FieldOffset(52)]
	[ReferenceTable("WorldAreas")]
	public TableReference Area2;

}
