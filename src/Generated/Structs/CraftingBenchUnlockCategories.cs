using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CraftingBenchUnlockCategories
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	[ElementType(typeof(int))]
	public TArray Unk002;

	[FieldOffset(28)]
	public TString UnlockType;

	[FieldOffset(36)]
	[ReferenceTable("CraftingItemClassCategories")]
	[ElementType(typeof(TRef))]
	public TArray CraftingItemClassCategories;

	[FieldOffset(52)]
	public TString ObtainingDescription;

}
