using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapStashSubstashGroup
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Label;

	[FieldOffset(16)]
	public TString Icon;

	[FieldOffset(24)]
	public TRef Unk003;

	[FieldOffset(40)]
	public TString Description;

}
