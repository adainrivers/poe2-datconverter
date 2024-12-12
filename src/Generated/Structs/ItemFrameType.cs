namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemFrameType
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public TBool Unk001;

	[FieldOffset(9)]
	public TBool DoubleLine;

	[FieldOffset(10)]
	public StringReference HeaderSingle;

	[FieldOffset(18)]
	public StringReference HeaderDouble;

	[FieldOffset(26)]
	public StringReference HardmodeHeaderSingle;

	[FieldOffset(34)]
	public StringReference HardmodeHeaderDouble;

	[FieldOffset(42)]
	[ElementType(typeof(int))]
	public ArrayReference Color;

	[FieldOffset(58)]
	public StringReference Separator;

	[FieldOffset(66)]
	public TBool Unk009;

	[FieldOffset(67)]
	[ReferenceTable("Rarity")]
	public TableReference Rarity;

	[FieldOffset(83)]
	[ReferenceTable("ClientStrings")]
	public TableReference DisplayString;

	[FieldOffset(99)]
	public StringReference ColorMarkup;

	[FieldOffset(107)]
	public int Unk013;

}
