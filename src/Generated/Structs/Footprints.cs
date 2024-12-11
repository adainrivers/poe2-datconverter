using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Footprints
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ElementType(typeof(TString))]
	public TArray Active_AOFiles;

	[FieldOffset(24)]
	[ElementType(typeof(TString))]
	public TArray Idle_AOFiles;

	[FieldOffset(40)]
	[ElementType(typeof(TString))]
	public TArray Unk003;

	[FieldOffset(56)]
	[ElementType(typeof(TString))]
	public TArray Unk004;

	[FieldOffset(72)]
	public int Unk005;

	[FieldOffset(76)]
	public TRef Unk006;

}
