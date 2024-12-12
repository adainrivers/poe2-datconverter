namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistDoodadNPCs
{
	[FieldOffset(0)]
	[ReferenceTable("NPCs")]
	public TableReference NPCsKey;

	[FieldOffset(16)]
	public TableReference Unk001;

	[FieldOffset(32)]
	public TableReference Unk002;

	[FieldOffset(48)]
	public int Unk003;

	[FieldOffset(52)]
	public int Unk004;

	[FieldOffset(56)]
	public int Unk005;

	[FieldOffset(60)]
	public StringReference AOFile;

	[FieldOffset(68)]
	public StringReference Stance;

	[FieldOffset(76)]
	[ReferenceTable("BetrayalTargets")]
	public TableReference BetrayalTargetsKey;

}
