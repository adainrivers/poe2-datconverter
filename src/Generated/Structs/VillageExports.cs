namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct VillageExports
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Name;

	[FieldOffset(16)]
	public int Unk002;

	[FieldOffset(20)]
	public StringReference Icon;

	[FieldOffset(28)]
	public int Unk004;

	[FieldOffset(32)]
	public int Unk005;

	[FieldOffset(36)]
	public StringReference Icon2;

	[FieldOffset(44)]
	public StringReference Name2;

	[FieldOffset(52)]
	public StringReference IconCombined;

	[FieldOffset(60)]
	[ReferenceTable("VillageExports")]
	public TableReference Result;

	[FieldOffset(68)]
	public int Unk010;

}
