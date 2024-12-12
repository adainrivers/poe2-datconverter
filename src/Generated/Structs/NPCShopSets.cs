namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NPCShopSets
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	public TableReference Unk002;

	[FieldOffset(28)]
	public TableReference Unk003;

	[FieldOffset(44)]
	public TableReference Unk004;

	[FieldOffset(60)]
	public int Unk005;

}
