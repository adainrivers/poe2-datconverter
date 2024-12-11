using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ChestClusters
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("Chests")]
	[ElementType(typeof(TRef))]
	public TArray ChestsKeys;

	[FieldOffset(24)]
	[ElementType(typeof(int))]
	public TArray Unk002;

	[FieldOffset(40)]
	public int Unk003;

	[FieldOffset(44)]
	public int Unk004;

	[FieldOffset(48)]
	public int Unk005;

}
