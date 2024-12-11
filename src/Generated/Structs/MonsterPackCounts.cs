using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterPackCounts
{
	[FieldOffset(0)]
	public TRef Unk000;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	[ElementType(typeof(TRef))]
	public TArray Unk002;

	[FieldOffset(36)]
	public bool Unk003;

	[FieldOffset(37)]
	[ElementType(typeof(int))]
	public TArray Unk004;

}
