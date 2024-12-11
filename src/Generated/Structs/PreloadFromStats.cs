using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PreloadFromStats
{
	[FieldOffset(0)]
	public TRef Unk000;

	[FieldOffset(16)]
	[ElementType(typeof(int))]
	public TArray Unk001;

	[FieldOffset(32)]
	[ElementType(typeof(int))]
	public TArray Unk002;

	[FieldOffset(48)]
	[ElementType(typeof(int))]
	public TArray Unk003;

	[FieldOffset(64)]
	[ElementType(typeof(int))]
	public TArray Unk004;

	[FieldOffset(80)]
	public int Unk005;

}
