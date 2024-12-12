namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ArchetypeRewards
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public TableReference Unk001;

	[FieldOffset(24)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk002;

	[FieldOffset(40)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference Gem;

	[FieldOffset(56)]
	public StringReference BK2File;

}
