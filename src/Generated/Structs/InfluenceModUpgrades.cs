using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct InfluenceModUpgrades
{
	[FieldOffset(0)]
	[ReferenceTable("Mods")]
	public TRef InfluenceMod;

	[FieldOffset(16)]
	[ReferenceTable("Mods")]
	public TRef UpgradedMod;

	[FieldOffset(32)]
	public TBool HighestTier;

}
