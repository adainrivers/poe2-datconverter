namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AncestralTrialTribes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public TableReference Unk001;

	[FieldOffset(24)]
	public StringReference Portrait;

	[FieldOffset(32)]
	public StringReference TribeIcon;

	[FieldOffset(40)]
	public StringReference TribeName;

	[FieldOffset(48)]
	public StringReference FavourTracker;

	[FieldOffset(56)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk006;

	[FieldOffset(72)]
	public StringReference Name;

	[FieldOffset(80)]
	public TableReference Unk008;

	[FieldOffset(96)]
	public TableReference Unk009;

	[FieldOffset(112)]
	public TableReference Unk010;

	[FieldOffset(128)]
	public TableReference Unk011;

	[FieldOffset(144)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk012;

	[FieldOffset(160)]
	public TableReference Unk013;

	[FieldOffset(176)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk014;

	[FieldOffset(192)]
	public int Unk015;

	[FieldOffset(196)]
	public int Unk016;

	[FieldOffset(200)]
	public int Unk017;

	[FieldOffset(204)]
	public int Unk018;

	[FieldOffset(208)]
	public TableReference Unk019;

}
