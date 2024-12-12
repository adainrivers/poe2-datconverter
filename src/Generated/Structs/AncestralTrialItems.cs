namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AncestralTrialItems
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int HASH16;

	[FieldOffset(12)]
	public StringReference Name;

	[FieldOffset(20)]
	public StringReference Image;

	[FieldOffset(28)]
	public TableReference Unk004;

	[FieldOffset(44)]
	public int Unk005;

	[FieldOffset(48)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Mods;

	[FieldOffset(64)]
	public StringReference FlavorText;

	[FieldOffset(72)]
	public int Unk008;

	[FieldOffset(76)]
	[ElementType(typeof(int))]
	public ArrayReference Unk009;

	[FieldOffset(92)]
	public TableReference Unk010;

	[FieldOffset(108)]
	public TableReference Unk011;

}
