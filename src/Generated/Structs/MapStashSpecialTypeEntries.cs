namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapStashSpecialTypeEntries
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference MapItem;

	[FieldOffset(28)]
	public StringReference Name;

	[FieldOffset(36)]
	public int Unk004;

	[FieldOffset(40)]
	public TBool IsShaperGuardian;

	[FieldOffset(41)]
	public TBool IsElderGuardian;

	[FieldOffset(42)]
	public TableReference Unk007;

	[FieldOffset(58)]
	public TableReference Unk008;

	[FieldOffset(74)]
	public TableReference Unk009;

}
