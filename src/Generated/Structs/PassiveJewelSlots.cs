namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PassiveJewelSlots
{
	[FieldOffset(0)]
	[ReferenceTable("PassiveSkills")]
	public TableReference Slot;

	[FieldOffset(16)]
	[ReferenceTable("PassiveTreeExpansionJewelSizes")]
	public TableReference ClusterJewelSize;

	[FieldOffset(32)]
	public int Unk002;

	[FieldOffset(36)]
	[ReferenceTable("PassiveJewelSlots")]
	public TableReference ReplacesSlot;

	[FieldOffset(44)]
	[ReferenceTable("PassiveSkills")]
	public TableReference ProxySlot;

	[FieldOffset(60)]
	[ElementType(typeof(int))]
	public ArrayReference StartIndices;

	[FieldOffset(76)]
	public TBool Unk006;

}
