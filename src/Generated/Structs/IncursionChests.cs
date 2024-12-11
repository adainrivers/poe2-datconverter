using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct IncursionChests
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("Chests")]
	public TRef ChestsKey;

	[FieldOffset(24)]
	[ReferenceTable("UniqueChests")]
	public TRef UniqueChestsKey;

	[FieldOffset(40)]
	public int MinLevel;

	[FieldOffset(44)]
	public int MaxLevel;

	[FieldOffset(48)]
	public int Weight;

	[FieldOffset(52)]
	public int Unk006;

}
