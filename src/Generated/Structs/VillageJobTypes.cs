namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct VillageJobTypes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Icon;

	[FieldOffset(16)]
	public StringReference StateText;

	[FieldOffset(24)]
	[ReferenceTable("Stats")]
	public TableReference MaxWorkersStat;

	[FieldOffset(40)]
	public TBool Unk004;

	[FieldOffset(41)]
	[ReferenceTable("Stats")]
	public TableReference JobSpeedStat;

}
