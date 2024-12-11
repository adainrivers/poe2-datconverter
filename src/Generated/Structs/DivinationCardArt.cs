using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DivinationCardArt
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItemTypesKey;

	[FieldOffset(16)]
	public TString VirtualFile;

	[FieldOffset(24)]
	[ReferenceTable("InfluenceTypes")]
	[EnumName("InfluenceTypes")]
	[ElementType(typeof(TEnum))]
	public TArray Influences;

}
