using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CraftingItemClassCategories
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("ItemClasses")]
	[ElementType(typeof(TRef))]
	public TArray ItemClasses;

	[FieldOffset(24)]
	public TString Unk002;

	[FieldOffset(32)]
	public TString Text;

	[FieldOffset(40)]
	[ElementType(typeof(TRef))]
	public TArray Unk004;

}
