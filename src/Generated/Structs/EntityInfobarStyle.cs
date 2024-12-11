using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct EntityInfobarStyle
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString FrameLeft;

	[FieldOffset(16)]
	public TString FrameMiddle;

	[FieldOffset(24)]
	public TString FrameRepeat;

	[FieldOffset(32)]
	public TString FrameRight;

	[FieldOffset(40)]
	public TString EntityLeft;

	[FieldOffset(48)]
	public TString EntityMiddle;

	[FieldOffset(56)]
	public TString EntityRepeat;

	[FieldOffset(64)]
	public TString EntityRight;

	[FieldOffset(72)]
	public TString EntityStats;

	[FieldOffset(80)]
	public TString EntityStatsSmall;

	[FieldOffset(88)]
	public int Unk011;

	[FieldOffset(92)]
	public int Unk012;

	[FieldOffset(96)]
	public TString LifeBar;

	[FieldOffset(104)]
	public TString LifeBarLeft;

	[FieldOffset(112)]
	public TString LifeBarMiddle;

	[FieldOffset(120)]
	public TString LifeBarRepeat;

	[FieldOffset(128)]
	public TString LifeBarRight;

}
