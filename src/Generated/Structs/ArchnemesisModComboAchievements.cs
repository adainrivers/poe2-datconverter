using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ArchnemesisModComboAchievements
{
	[FieldOffset(0)]
	[ReferenceTable("AchievementItems")]
	public TRef Achievement;

	[FieldOffset(16)]
	[ReferenceTable("ArchnemesisMods")]
	[ElementType(typeof(TRef))]
	public TArray Mods;

}
