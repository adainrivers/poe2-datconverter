using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct VillageJobTypes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Icon;

	[FieldOffset(16)]
	public TString StateText;

	[FieldOffset(24)]
	[ReferenceTable("Stats")]
	public TRef MaxWorkersStat;

	[FieldOffset(40)]
	public TBool Unk004;

	[FieldOffset(41)]
	[ReferenceTable("Stats")]
	public TRef JobSpeedStat;

}
