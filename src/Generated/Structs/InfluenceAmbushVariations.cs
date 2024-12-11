using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct InfluenceAmbushVariations
{
	[FieldOffset(0)]
	public TRef Unk000;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	public float Unk002;

	[FieldOffset(24)]
	[ElementType(typeof(int))]
	public TArray Unk003;

	[FieldOffset(40)]
	public int Unk004;

	[FieldOffset(44)]
	public int Unk005;

	[FieldOffset(48)]
	public int Unk006;

	[FieldOffset(52)]
	public float Unk007;

	[FieldOffset(56)]
	public float Unk008;

}
