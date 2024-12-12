namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistLockType
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("HeistJobs")]
	public TableReference HeistJobsKey;

	[FieldOffset(24)]
	public StringReference SkillIcon;

}
