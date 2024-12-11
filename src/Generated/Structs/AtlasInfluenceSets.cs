using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AtlasInfluenceSets
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("AtlasInfluenceOutcomes")]
	[ElementType(typeof(TRef))]
	public TArray InfluencePacks;

}
