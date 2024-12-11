using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TradeMarketCategory
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Name;

	[FieldOffset(16)]
	[ReferenceTable("TradeMarketCategoryStyleFlag")]
	[EnumName("TradeMarketCategoryStyleFlag")]
	public TEnum StyleFlag;

	[FieldOffset(20)]
	[ReferenceTable("TradeMarketCategoryGroups")]
	public TRef Group;

	[FieldOffset(36)]
	[ElementType(typeof(int))]
	public TArray Unk004;

	[FieldOffset(52)]
	public bool Unk005;

	[FieldOffset(53)]
	public bool IsDisabled;

}
