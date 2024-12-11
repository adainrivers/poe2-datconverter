using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HellscapeMods
{
	[FieldOffset(0)]
	[ReferenceTable("Mods")]
	public TRef Mod;

	[FieldOffset(16)]
	[ElementType(typeof(int))]
	public TArray TiersWhitelist;

	[FieldOffset(32)]
	[ReferenceTable("AchievementItems")]
	public TRef TransformAchievement;

	[FieldOffset(48)]
	[ReferenceTable("ModFamily")]
	[ElementType(typeof(TRef))]
	public TArray ModFamilies;

}
