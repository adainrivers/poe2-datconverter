using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct VillageJobs
{
	[FieldOffset(0)]
	public TRef Unk000;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	public TString Status;

	[FieldOffset(28)]
	[ReferenceTable("Stats")]
	public TRef Stat;

	[FieldOffset(44)]
	public int StatValue;

}
