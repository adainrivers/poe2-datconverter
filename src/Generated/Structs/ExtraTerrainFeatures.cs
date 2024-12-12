namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ExtraTerrainFeatures
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ElementType(typeof(StringReference))]
	public ArrayReference ArmFiles;

	[FieldOffset(24)]
	[ElementType(typeof(StringReference))]
	public ArrayReference TdtFiles;

	[FieldOffset(40)]
	public TBool Unk003;

	[FieldOffset(41)]
	[ElementType(typeof(StringReference))]
	public ArrayReference Unk004;

	[FieldOffset(57)]
	[ElementType(typeof(int))]
	public ArrayReference Unk005;

	[FieldOffset(73)]
	[ReferenceTable("ExtraTerrainFeatures")]
	public TableReference Unk006;

	[FieldOffset(81)]
	[ReferenceTable("WorldAreas")]
	public TableReference WorldAreasKey;

	[FieldOffset(97)]
	public TBool Unk008;

	[FieldOffset(98)]
	public int Unk009;

}
