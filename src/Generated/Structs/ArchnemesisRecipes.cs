namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ArchnemesisRecipes
{
	[FieldOffset(0)]
	[ReferenceTable("ArchnemesisMods")]
	public TableReference Result;

	[FieldOffset(16)]
	[ReferenceTable("ArchnemesisMods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Recipe;

	[FieldOffset(32)]
	public int Unk002;

}
