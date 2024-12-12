namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DroneTypes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("QuestFlags")]
	public TableReference Unk001;

	[FieldOffset(24)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference Unk002;

	[FieldOffset(40)]
	public StringReference DeployText;

	[FieldOffset(48)]
	public StringReference Unk004;

	[FieldOffset(56)]
	[ReferenceTable("Stats")]
	public TableReference UnlockedStat;

	[FieldOffset(72)]
	public StringReference SocketableText;

	[FieldOffset(80)]
	public StringReference NotPoweredText;

}
