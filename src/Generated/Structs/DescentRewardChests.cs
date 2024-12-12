namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DescentRewardChests
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference BaseItemTypesKeys1;

	[FieldOffset(24)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference BaseItemTypesKeys2;

	[FieldOffset(40)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference BaseItemTypesKeys3;

	[FieldOffset(56)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference BaseItemTypesKeys4;

	[FieldOffset(72)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference BaseItemTypesKeys5;

	[FieldOffset(88)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference BaseItemTypesKeys6;

	[FieldOffset(104)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference BaseItemTypesKeys7;

	[FieldOffset(120)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference BaseItemTypesKeys8;

	[FieldOffset(136)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference BaseItemTypesKeys9;

	[FieldOffset(152)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference BaseItemTypesKeys10;

	[FieldOffset(168)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference BaseItemTypesKeys11;

	[FieldOffset(184)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference BaseItemTypesKeys12;

	[FieldOffset(200)]
	[ReferenceTable("WorldAreas")]
	public TableReference WorldAreasKey;

	[FieldOffset(216)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference BaseItemTypesKeys13;

	[FieldOffset(232)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference BaseItemTypesKeys14;

}
