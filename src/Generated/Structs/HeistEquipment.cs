using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistEquipment
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItemTypesKey;

	[FieldOffset(16)]
	[ReferenceTable("HeistJobs")]
	public TRef RequiredJob_HeistJobsKey;

	[FieldOffset(32)]
	public int RequiredLevel;

}
