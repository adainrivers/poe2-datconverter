using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SynthesisGlobalMods
{
	[FieldOffset(0)]
	[ReferenceTable("Mods")]
	public TRef ModsKey;

	[FieldOffset(16)]
	public int Weight;

	[FieldOffset(20)]
	public int MinLevel;

	[FieldOffset(24)]
	public int MaxLevel;

}
