namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BeltTypes
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemTypesKey;

    [FieldOffset(16)]
    public int CharmSlots;

}
