namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemVisualReplacement
{
	[FieldOffset(0)]
    [ReferenceTable("BaseItemTypes")]
    public TableReference BaseItemType;

	[FieldOffset(16)]
	public TableReference Unk001;

	[FieldOffset(32)]
	public TableReference Unk002;

}
