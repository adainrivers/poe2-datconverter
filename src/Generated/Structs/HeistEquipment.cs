namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistEquipment
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemTypesKey;

	[FieldOffset(16)]
	[ReferenceTable("HeistJobs")]
	public TableReference RequiredJob_HeistJobsKey;

	[FieldOffset(32)]
	public int RequiredLevel;

}
