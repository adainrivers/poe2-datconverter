namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CloneShot
{
	[FieldOffset(0)]
	public int Id;

	[FieldOffset(4)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference MonsterVarietiesKey;

	[FieldOffset(20)]
	[ReferenceTable("MiscAnimated")]
	public TableReference MiscAnimated1;

	[FieldOffset(36)]
	[ReferenceTable("MiscAnimated")]
	public TableReference MiscAnimated2;

	[FieldOffset(52)]
	[ReferenceTable("MiscAnimated")]
	public TableReference MiscAnimated3;

}
