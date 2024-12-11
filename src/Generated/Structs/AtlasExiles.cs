using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AtlasExiles
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	[ReferenceTable("Stats")]
	public TRef InfluencedItemIncrStat;

	[FieldOffset(28)]
	public TString MapIcon;

	[FieldOffset(36)]
	public TString MapIcon2;

}
