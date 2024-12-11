using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ExpandingPulse
{
	[FieldOffset(0)]
	public int IntId;

	[FieldOffset(4)]
	public TString StringId;

	[FieldOffset(12)]
	[ElementType(typeof(int))]
	public TArray Unk002;

	[FieldOffset(28)]
	[ElementType(typeof(float))]
	public TArray Unk003;

	[FieldOffset(44)]
	[ElementType(typeof(TRef))]
	public TArray Unk004;

	[FieldOffset(60)]
	public int Unk005;

	[FieldOffset(64)]
	public int Unk006;

	[FieldOffset(68)]
	public bool Unk007;

}
