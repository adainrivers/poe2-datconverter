using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ExpeditionRelicMods
{
	[FieldOffset(0)]
	[ReferenceTable("Mods")]
	public TRef Mod;

	[FieldOffset(16)]
	[ReferenceTable("ExpeditionRelicModCategories")]
	[EnumName("ExpeditionRelicModCategories")]
	[ElementType(typeof(TEnum))]
	public TArray Categories;

	[FieldOffset(32)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray DestroyAchievements;

}
