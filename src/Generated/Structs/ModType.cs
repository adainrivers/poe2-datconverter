using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ModType
{
	[FieldOffset(0)]
	public TString Name;

	[FieldOffset(8)]
	[ReferenceTable("ModSellPriceTypes")]
	[ElementType(typeof(TRef))]
	public TArray ModSellPriceTypesKeys;

	[FieldOffset(24)]
	public bool Unk002;

}
