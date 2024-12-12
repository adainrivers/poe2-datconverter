namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Races
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Mods;

	[FieldOffset(24)]
	public StringReference Unk002;

	[FieldOffset(32)]
	public StringReference Unk003;

	[FieldOffset(40)]
	public int Unk004;

	[FieldOffset(44)]
	public int Unk005;

	[FieldOffset(48)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk006;

	[FieldOffset(64)]
	public TBool Unk007;

	[FieldOffset(65)]
	public int Unk008;

	[FieldOffset(69)]
	[ElementType(typeof(int))]
	public ArrayReference Unk009;

	[FieldOffset(85)]
	[ElementType(typeof(int))]
	public ArrayReference Unk010;

}
