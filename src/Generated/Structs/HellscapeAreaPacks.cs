namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HellscapeAreaPacks
{
	[FieldOffset(0)]
	[ReferenceTable("WorldAreas")]
	public TableReference WorldArea;

	[FieldOffset(16)]
	[ReferenceTable("MonsterPacks")]
	[ElementType(typeof(TableReference))]
	public ArrayReference MonsterPacks;

	[FieldOffset(32)]
	public int Unk002;

	[FieldOffset(36)]
	public int Unk003;

}
