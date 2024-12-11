using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AnimatedObjectFlags
{
	[FieldOffset(0)]
	public TString AOFile;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	public bool Unk002;

	[FieldOffset(13)]
	public bool Unk003;

}
