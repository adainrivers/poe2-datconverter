using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NecropolisPacksPerArea
{
	[FieldOffset(0)]
	public TRef Unk000;

	[FieldOffset(16)]
	[ElementType(typeof(TRef))]
	public TArray Unk001;

	[FieldOffset(32)]
	[ElementType(typeof(int))]
	public TArray Unk002;

}
