using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BlightCraftingItems
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef Oil;

	[FieldOffset(16)]
	public int Tier;

	[FieldOffset(20)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray Achievements;

	[FieldOffset(36)]
	public int UseType;

	[FieldOffset(40)]
	public TString NameShort;

}
