namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ChanceableItemClasses
{
	[FieldOffset(0)]
	[ReferenceTable("ItemClasses")]
    public TableReference ItemClass;

}
