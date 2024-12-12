namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistRevealingNPCs
{
	[FieldOffset(0)]
	[ReferenceTable("NPCs")]
	public TableReference NPCsKey;

	[FieldOffset(16)]
	public StringReference PortraitFile;

	[FieldOffset(24)]
	[ReferenceTable("NPCAudio")]
	[ElementType(typeof(TableReference))]
	public ArrayReference NPCAudioKey;

	[FieldOffset(40)]
	public int Unk003;

}
