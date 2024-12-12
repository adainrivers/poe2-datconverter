namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemCosts
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Cost1Currencies;

	[FieldOffset(24)]
	[ElementType(typeof(int))]
	public ArrayReference Cost1Values;

	[FieldOffset(40)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Cost2Currencies;

	[FieldOffset(56)]
	[ElementType(typeof(int))]
	public ArrayReference Cost2Values;

	[FieldOffset(72)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Cost3Currencies;

	[FieldOffset(88)]
	[ElementType(typeof(int))]
	public ArrayReference Cost3Values;

	[FieldOffset(104)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Cost4Currencies;

	[FieldOffset(120)]
	[ElementType(typeof(int))]
	public ArrayReference Cost4Values;

	[FieldOffset(136)]
	[ElementType(typeof(int))]
	public ArrayReference Unk009;

}
