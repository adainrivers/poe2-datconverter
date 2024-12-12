namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct IncursionChests
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("Chests")]
	public TableReference ChestsKey;

	[FieldOffset(24)]
	[ReferenceTable("UniqueChests")]
	public TableReference UniqueChestsKey;

	[FieldOffset(40)]
	public int MinLevel;

	[FieldOffset(44)]
	public int MaxLevel;

	[FieldOffset(48)]
	public int Weight;

	[FieldOffset(52)]
	public int Unk006;

}
