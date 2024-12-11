using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MouseCursorSizeSettings
{
	[FieldOffset(0)]
	public TString Size;

	[FieldOffset(8)]
	public TString Description;

	[FieldOffset(16)]
	public float Ratio;

}
