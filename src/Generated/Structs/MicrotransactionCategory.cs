namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MicrotransactionCategory
{
	[FieldOffset(0)]
	[ReferenceTable("MicrotransactionCategoryId")]
	[EnumName("MicrotransactionCategoryId")]
	public TEnum Id;

	[FieldOffset(4)]
	public StringReference Name;

}
