using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct FootstepAudio
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int Index;

}
