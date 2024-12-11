using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MTXSetBonus
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TRef Unk001;

	[FieldOffset(24)]
	[ElementType(typeof(TRef))]
	public TArray Unk002;

	[FieldOffset(40)]
	[ElementType(typeof(TRef))]
	public TArray Unk003;

	[FieldOffset(56)]
	[ElementType(typeof(TRef))]
	public TArray Unk004;

	[FieldOffset(72)]
	[ElementType(typeof(TRef))]
	public TArray Unk005;

}
