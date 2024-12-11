using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AfflictionFixedMods
{
	[FieldOffset(0)]
	public int Rarity;

	[FieldOffset(4)]
	[ReferenceTable("Mods")]
	public TRef Mod;

	[FieldOffset(20)]
	public TRef Unk002;

}
