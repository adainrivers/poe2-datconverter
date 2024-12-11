using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LabyrinthIzaroChests
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("Chests")]
	public TRef ChestsKey;

	[FieldOffset(24)]
	public int SpawnWeight;

	[FieldOffset(28)]
	public int MinLabyrinthTier;

	[FieldOffset(32)]
	public int MaxLabyrinthTier;

	[FieldOffset(36)]
	public int Unk005;

}
