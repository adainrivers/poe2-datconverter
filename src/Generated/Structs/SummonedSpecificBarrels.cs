namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SummonedSpecificBarrels
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("Chests")]
	public TableReference Chest;

	[FieldOffset(24)]
	public TableReference Unk002;

	[FieldOffset(40)]
	public TableReference Unk003;

	[FieldOffset(56)]
	public TableReference Unk004;

	[FieldOffset(72)]
	public StringReference Unk005;

}
