using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AlternateTreeArt
{
	[FieldOffset(0)]
	public TRef Unk000;

	[FieldOffset(16)]
	public TString Circle1;

	[FieldOffset(24)]
	public TString Circle2;

	[FieldOffset(32)]
	public TString Glow;

}
