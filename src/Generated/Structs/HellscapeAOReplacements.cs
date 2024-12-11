using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HellscapeAOReplacements
{
	[FieldOffset(0)]
	public TString Original;

	[FieldOffset(8)]
	public int HASH32;

	[FieldOffset(12)]
	public TString Replacement;

}
