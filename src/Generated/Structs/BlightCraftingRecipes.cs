using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BlightCraftingRecipes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("BlightCraftingItems")]
	[ElementType(typeof(TRef))]
	public TArray BlightCraftingItemsKeys;

	[FieldOffset(24)]
	[ReferenceTable("BlightCraftingResults")]
	public TRef BlightCraftingResultsKey;

	[FieldOffset(40)]
	[ReferenceTable("BlightCraftingTypes")]
	public TRef BlightCraftingTypesKey;

}
