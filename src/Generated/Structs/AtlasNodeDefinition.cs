namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AtlasNodeDefinition
{
	[FieldOffset(0)]
	[ReferenceTable("WorldAreas")]
	public TableReference WorldAreasKey;

	[FieldOffset(16)]
	[ReferenceTable("ItemVisualIdentity")]
	public TableReference ItemVisualIdentityKey;

	[FieldOffset(32)]
	public TBool Unk002;

	[FieldOffset(33)]
	public int Tier;

	[FieldOffset(37)]
	public int Unk004;

	[FieldOffset(41)]
	public int Unk005;

	[FieldOffset(45)]
	public TBool Unk006;

}
