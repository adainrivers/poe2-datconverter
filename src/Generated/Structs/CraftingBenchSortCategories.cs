using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CraftingBenchSortCategories
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("ClientStrings")]
	public TRef Name;

	[FieldOffset(24)]
	public bool IsVisible;

	[FieldOffset(25)]
	[ReferenceTable("CraftingBenchTypes")]
	public TRef Type;

}
