namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistNPCBlueprintTypes
{
	[FieldOffset(0)]
	[ReferenceTable("NPCs")]
	public TableReference NPCsKey;

	[FieldOffset(16)]
	public int Unk001;

}
