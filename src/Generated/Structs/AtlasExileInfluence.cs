using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AtlasExileInfluence
{
	[FieldOffset(0)]
	[ReferenceTable("AtlasExiles")]
	public TRef Conqueror;

	[FieldOffset(16)]
	[ReferenceTable("AtlasInfluenceSets")]
	[ElementType(typeof(TRef))]
	public TArray Sets;

}
