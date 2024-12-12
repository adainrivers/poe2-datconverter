namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MiscEffectPacks
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference EPKFile;

	[FieldOffset(16)]
	public int Unk002;

	[FieldOffset(20)]
	public int Unk003;

	[FieldOffset(24)]
	public int Unk004;

	[FieldOffset(28)]
	[ReferenceTable("PreloadGroups")]
	[ElementType(typeof(TableReference))]
	public ArrayReference PreloadGroups;

	[FieldOffset(44)]
	public TBool Unk006;

	[FieldOffset(45)]
	public StringReference PlayerOnly_EPKFile;

	[FieldOffset(53)]
	public TBool Unk008;

}
