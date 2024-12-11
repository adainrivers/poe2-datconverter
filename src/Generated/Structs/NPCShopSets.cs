using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NPCShopSets
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	public TRef Unk002;

	[FieldOffset(28)]
	public TRef Unk003;

	[FieldOffset(44)]
	public TRef Unk004;

	[FieldOffset(60)]
	public int Unk005;

}
