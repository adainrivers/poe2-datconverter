namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Tutorial
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference UIFile;

	[FieldOffset(16)]
	[ReferenceTable("ClientStrings")]
	public TableReference ClientString;

	[FieldOffset(32)]
	public TBool IsEnabled;

	[FieldOffset(33)]
	public int Unk004;

	[FieldOffset(37)]
	[ElementType(typeof(int))]
	public ArrayReference Unk005;

	[FieldOffset(53)]
	public TableReference Unk006;

	[FieldOffset(69)]
	public int Unk007;

	[FieldOffset(73)]
	[ElementType(typeof(int))]
	public ArrayReference Unk008;

	[FieldOffset(89)]
	public TBool Unk009;

	[FieldOffset(90)]
	public TBool Unk010;

	[FieldOffset(91)]
	public int Unk011;

}
