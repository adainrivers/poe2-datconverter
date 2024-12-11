using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NecropolisPackMods
{
	[FieldOffset(0)]
	[ReferenceTable("Mods")]
	public TRef Mod;

	[FieldOffset(16)]
	[ReferenceTable("NecropolisPackModTiers")]
	public TRef Tier;

	[FieldOffset(32)]
	[ReferenceTable("NecropolisPackMods")]
	public TRef NextTier;

	[FieldOffset(40)]
	[ReferenceTable("NecropolisPackMods")]
	public TRef PrevTier;

}
