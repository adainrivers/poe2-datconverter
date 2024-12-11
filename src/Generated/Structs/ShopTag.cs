using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ShopTag
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Name;

	[FieldOffset(16)]
	public bool IsCategory;

	[FieldOffset(17)]
	[ReferenceTable("ShopTag")]
	public TRef Category;

	[FieldOffset(25)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TRef))]
	public TArray SkillGem;

}
