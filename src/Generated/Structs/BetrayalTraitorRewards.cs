namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BetrayalTraitorRewards
{
	[FieldOffset(0)]
	[ReferenceTable("BetrayalJobs")]
	public TableReference BetrayalJobsKey;

	[FieldOffset(16)]
	[ReferenceTable("BetrayalTargets")]
	public TableReference BetrayalTargetsKey;

	[FieldOffset(32)]
	[ReferenceTable("BetrayalRanks")]
	public TableReference BetrayalRanksKey;

	[FieldOffset(48)]
	public StringReference Description;

	[FieldOffset(56)]
	public StringReference Description2;

}
