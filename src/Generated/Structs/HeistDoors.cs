using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistDoors
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Unk001;

	[FieldOffset(16)]
	[ReferenceTable("HeistJobs")]
	public TRef HeistJobsKey1;

	[FieldOffset(32)]
	[ReferenceTable("HeistJobs")]
	public TRef HeistJobsKey2;

	[FieldOffset(48)]
	public TString Unk004;

	[FieldOffset(56)]
	[ElementType(typeof(TString))]
	public TArray Unk005;

	[FieldOffset(72)]
	[ElementType(typeof(TString))]
	public TArray Unk006;

	[FieldOffset(88)]
	public int Unk007;

	[FieldOffset(92)]
	[ReferenceTable("HeistAreas")]
	public TRef HeistAreasKey;

}
