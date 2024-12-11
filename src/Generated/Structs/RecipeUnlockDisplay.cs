using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct RecipeUnlockDisplay
{
	[FieldOffset(0)]
	public int RecipeId;

	[FieldOffset(4)]
	public TString Description;

	[FieldOffset(12)]
	[ReferenceTable("CraftingItemClassCategories")]
	[ElementType(typeof(TRef))]
	public TArray CraftingItemClassCategoriesKeys;

	[FieldOffset(28)]
	public TString UnlockDescription;

	[FieldOffset(36)]
	public int Rank;

	[FieldOffset(40)]
	[ReferenceTable("WorldAreas")]
	public TRef UnlockArea;

}
