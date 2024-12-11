using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PassiveSkillTreeUIArt
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString GroupBackgroundSmall;

	[FieldOffset(16)]
	public TString GroupBackgroundMedium;

	[FieldOffset(24)]
	public TString GroupBackgroundLarge;

	[FieldOffset(32)]
	public bool Unk004;

	[FieldOffset(33)]
	public TString PassiveFrameNormal;

	[FieldOffset(41)]
	public TString NotableFrameNormal;

	[FieldOffset(49)]
	public TString KeystoneFrameNormal;

	[FieldOffset(57)]
	public TString PassiveFrameActive;

	[FieldOffset(65)]
	public TString NotableFrameActive;

	[FieldOffset(73)]
	public TString KeystoneFrameActive;

	[FieldOffset(81)]
	public TString PassiveFrameCanAllocate;

	[FieldOffset(89)]
	public TString NotableFrameCanAllocate;

	[FieldOffset(97)]
	public TString KeystoneCanAllocate;

	[FieldOffset(105)]
	public TString Ornament;

	[FieldOffset(113)]
	public TString GroupBackgroundSmallBlank;

	[FieldOffset(121)]
	public TString GroupBackgroundMediumBlank;

	[FieldOffset(129)]
	public TString GroupBackgroundLargeBlank;

}
