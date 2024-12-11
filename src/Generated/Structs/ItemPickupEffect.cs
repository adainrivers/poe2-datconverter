using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemPickupEffect
{
	[FieldOffset(0)]
	public TRef Unk000;

	[FieldOffset(16)]
	public TRef Unk001;

	[FieldOffset(32)]
	public TRef Unk002;

	[FieldOffset(48)]
	public int Unk003;

}
