using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LegionRewardTypeVisuals
{
	[FieldOffset(0)]
	public int IntId;

	[FieldOffset(4)]
	[ReferenceTable("MinimapIcons")]
	public TRef MinimapIconsKey;

	[FieldOffset(20)]
	public TString Unk002;

	[FieldOffset(28)]
	[ReferenceTable("MiscAnimated")]
	public TRef MiscAnimatedKey;

	[FieldOffset(44)]
	public float Unk004;

	[FieldOffset(48)]
	public TString Id;

}
