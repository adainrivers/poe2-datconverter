namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Ascendancy
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int ClassNo;

	[FieldOffset(12)]
	[ReferenceTable("Characters")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Characters;

	[FieldOffset(28)]
	public StringReference CoordinateRect;

	[FieldOffset(36)]
	public StringReference RGBFlavourTextColour;

	[FieldOffset(44)]
	public StringReference Name;

	[FieldOffset(52)]
	public StringReference FlavourText;

	[FieldOffset(60)]
	public StringReference OGGFile;

	[FieldOffset(68)]
	public StringReference PassiveTreeImage;

	[FieldOffset(76)]
	public int Unk009;

	[FieldOffset(80)]
	public int Unk010;

	[FieldOffset(84)]
	public int Unk011;

    [FieldOffset(88)]
    public int Unk012;

    [FieldOffset(92)]
	public TBool Unk013;

}
