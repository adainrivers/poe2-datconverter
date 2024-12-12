namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ShopTag
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Name;

	[FieldOffset(16)]
	public TBool IsCategory;

	[FieldOffset(17)]
	[ReferenceTable("ShopTag")]
	public TableReference Category;

	[FieldOffset(25)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference SkillGem;

}
