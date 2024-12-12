namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Strongboxes
{
	[FieldOffset(0)]
	[ReferenceTable("Chests")]
	public TableReference ChestsKey;

	[FieldOffset(16)]
	public int SpawnWeight;

	[FieldOffset(20)]
	public int Unk002;

	[FieldOffset(24)]
	public TBool Unk003;

	[FieldOffset(25)]
	public TBool Unk004;

	[FieldOffset(26)]
	[ReferenceTable("Stats")]
	public TableReference SpawnWeightIncrease;

	[FieldOffset(42)]
	public int SpawnWeightHardmode;

}
