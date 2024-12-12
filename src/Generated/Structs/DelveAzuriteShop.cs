namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DelveAzuriteShop
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemTypesKey;

	[FieldOffset(16)]
	public int SpawnWeight;

	[FieldOffset(20)]
	public int Cost;

	[FieldOffset(24)]
	public int MinDepth;

	[FieldOffset(28)]
	public TBool IsResonator;

	[FieldOffset(29)]
	public int Unk005;

	[FieldOffset(33)]
	public int Unk006;

}
