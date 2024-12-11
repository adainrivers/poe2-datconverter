using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LabyrinthNodeOverrides
{
	[FieldOffset(0)]
	public TString Id1;

	[FieldOffset(8)]
	public TString Id2;

	[FieldOffset(16)]
	[ElementType(typeof(int))]
	public TArray Unk002;

	[FieldOffset(32)]
	[ElementType(typeof(int))]
	public TArray Unk003;

}
