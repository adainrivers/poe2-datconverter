using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SummonedSpecificBarrels
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("Chests")]
	public TRef Chest;

	[FieldOffset(24)]
	public TRef Unk002;

	[FieldOffset(40)]
	public TRef Unk003;

	[FieldOffset(56)]
	public TRef Unk004;

	[FieldOffset(72)]
	public TString Unk005;

}
