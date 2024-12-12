namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LabyrinthIzaroChests
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("Chests")]
	public TableReference ChestsKey;

	[FieldOffset(24)]
	public int SpawnWeight;

	[FieldOffset(28)]
	public int MinLabyrinthTier;

	[FieldOffset(32)]
	public int MaxLabyrinthTier;

	[FieldOffset(36)]
	public int Unk005;

}
