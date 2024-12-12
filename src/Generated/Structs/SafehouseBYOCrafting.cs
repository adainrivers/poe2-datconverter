namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SafehouseBYOCrafting
{
	[FieldOffset(0)]
	[ReferenceTable("BetrayalJobs")]
	public TableReference BetrayalJobsKey;

	[FieldOffset(16)]
	[ReferenceTable("BetrayalTargets")]
	public TableReference BetrayalTargetsKey;

	[FieldOffset(32)]
	public int Rank;

	[FieldOffset(36)]
	public StringReference Description;

	[FieldOffset(44)]
	public StringReference ServerCommand;

	[FieldOffset(52)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk005;

	[FieldOffset(68)]
	public StringReference Description2;

	[FieldOffset(76)]
	public StringReference ServerCommand2;

}
