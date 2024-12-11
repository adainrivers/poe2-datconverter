using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct InfluenceTags
{
	[FieldOffset(0)]
	[ReferenceTable("ItemClasses")]
	public TRef ItemClass;

	[FieldOffset(16)]
	[ReferenceTable("InfluenceTypes")]
	[EnumName("InfluenceTypes")]
	public TEnum Influence;

	[FieldOffset(20)]
	[ReferenceTable("Tags")]
	public TRef Tag;

}
