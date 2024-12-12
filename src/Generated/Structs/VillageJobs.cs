namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct VillageJobs
{
	[FieldOffset(0)]
	public TableReference Unk000;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	public StringReference Status;

	[FieldOffset(28)]
	[ReferenceTable("Stats")]
	public TableReference Stat;

	[FieldOffset(44)]
	public int StatValue;

}
