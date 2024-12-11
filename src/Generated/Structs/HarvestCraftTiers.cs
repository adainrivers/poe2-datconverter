using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HarvestCraftTiers
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString FrameImage;

	[FieldOffset(16)]
	public TString FrameHighlight;

}
