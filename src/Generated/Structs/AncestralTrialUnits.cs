namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AncestralTrialUnits
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Name;

	[FieldOffset(16)]
	[ReferenceTable("AncestralTrialTribes")]
	public TableReference Tribe;

	[FieldOffset(32)]
	public StringReference Image;

	[FieldOffset(40)]
	public StringReference TotemImage;

	[FieldOffset(48)]
	public int HASH16;

	[FieldOffset(52)]
	public int Unk006;

	[FieldOffset(56)]
	public StringReference Description;

	[FieldOffset(64)]
	public int Unk008;

	[FieldOffset(68)]
	public int Unk009;

	[FieldOffset(72)]
	[ReferenceTable("AncestralTrialUnitPositions")]
	public TableReference Position;

}
