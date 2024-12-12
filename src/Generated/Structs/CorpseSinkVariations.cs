namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CorpseSinkVariations
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference AOFile;

	[FieldOffset(16)]
	public StringReference EPKFile;

	[FieldOffset(24)]
	[ElementType(typeof(StringReference))]
	public ArrayReference AOFiles;

	[FieldOffset(40)]
	public int Unk004;

	[FieldOffset(44)]
	public TBool Unk005;

	[FieldOffset(45)]
	public int Unk006;

	[FieldOffset(49)]
	public int Unk007;

	[FieldOffset(53)]
	public TBool Unk008;

}
