using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GroundEffectTypes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	public float Unk002;

	[FieldOffset(16)]
	public TRef Unk003;

	[FieldOffset(32)]
	public TRef Unk004;

	[FieldOffset(48)]
	public TRef Unk005;

}
