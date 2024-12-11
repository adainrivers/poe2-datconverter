using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Strongboxes
{
	[FieldOffset(0)]
	[ReferenceTable("Chests")]
	public TRef ChestsKey;

	[FieldOffset(16)]
	public int SpawnWeight;

	[FieldOffset(20)]
	public int Unk002;

	[FieldOffset(24)]
	public bool Unk003;

	[FieldOffset(25)]
	public bool Unk004;

	[FieldOffset(26)]
	[ReferenceTable("Stats")]
	public TRef SpawnWeightIncrease;

	[FieldOffset(42)]
	public int SpawnWeightHardmode;

}
