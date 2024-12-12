namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct StampChoice
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public TableReference Unk001;

	[FieldOffset(24)]
	public int Unk002;

	[FieldOffset(28)]
	public StringReference Effect;

	[FieldOffset(36)]
	public StringReference Icon;

	[FieldOffset(44)]
	public TableReference Unk005;

	[FieldOffset(60)]
	[ElementType(typeof(int))]
	public ArrayReference Unk006;

	[FieldOffset(76)]
	public int Unk007;

}
