namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistIntroAreas
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("HeistAreas")]
	public TableReference HeistAreasKey;

	[FieldOffset(24)]
	public int Unk002;

	[FieldOffset(28)]
	public int Unk003;

	[FieldOffset(32)]
	public StringReference DGRFile;

	[FieldOffset(40)]
	public int Unk005;

	[FieldOffset(44)]
	public int Unk006;

	[FieldOffset(48)]
	public TBool Unk007;

	[FieldOffset(49)]
	public int Unk008;

	[FieldOffset(53)]
	public int Unk009;

	[FieldOffset(57)]
	public int Unk010;

}
