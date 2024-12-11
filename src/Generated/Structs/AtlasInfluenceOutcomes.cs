using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AtlasInfluenceOutcomes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	[ReferenceTable("AtlasInfluenceOutcomeTypes")]
	[EnumName("AtlasInfluenceOutcomeTypes")]
	public TEnum Type;

}
