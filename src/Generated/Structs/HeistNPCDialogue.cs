namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistNPCDialogue
{
	[FieldOffset(0)]
	[ReferenceTable("DialogueEvent")]
	public TableReference DialogueEventKey;

	[FieldOffset(16)]
	[ReferenceTable("HeistNPCs")]
	public TableReference HeistNPCsKey;

	[FieldOffset(32)]
	[ReferenceTable("NPCTextAudio")]
	[ElementType(typeof(TableReference))]
	public ArrayReference AudioNormal;

	[FieldOffset(48)]
	[ReferenceTable("NPCTextAudio")]
	[ElementType(typeof(TableReference))]
	public ArrayReference AudioLoud;

	[FieldOffset(64)]
	public int Unk004;

}
