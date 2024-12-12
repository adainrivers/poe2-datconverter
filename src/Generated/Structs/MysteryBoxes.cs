namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MysteryBoxes
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemTypesKey;

	[FieldOffset(16)]
	public StringReference BK2File;

	[FieldOffset(24)]
	public StringReference BoxId;

	[FieldOffset(32)]
	public StringReference BundleId;

	[FieldOffset(40)]
	public TBool Unk004;

}
