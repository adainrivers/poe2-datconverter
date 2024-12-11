using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistLockType
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("HeistJobs")]
	public TRef HeistJobsKey;

	[FieldOffset(24)]
	public TString SkillIcon;

}
