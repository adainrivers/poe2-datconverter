using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct EnvironmentTransitions
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ElementType(typeof(TString))]
	public TArray OTFiles;

	[FieldOffset(24)]
	[ElementType(typeof(TString))]
	public TArray Unk002;

}
