using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Achievements
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Description;

	[FieldOffset(16)]
	[ReferenceTable("AchievementSetsDisplay")]
	public int SetId;

	[FieldOffset(20)]
	public TString Objective;

	[FieldOffset(28)]
	public short HASH16;

	[FieldOffset(30)]
	public bool Unk005;

	[FieldOffset(31)]
	public bool HideAchievementItems;

	[FieldOffset(32)]
	public bool Unk007;

	[FieldOffset(33)]
	public int MinCompletedItems;

	[FieldOffset(37)]
	public bool TwoColumnLayout;

	[FieldOffset(38)]
	public bool ShowItemCompletionsAsOne;

	[FieldOffset(39)]
	public TString Unk011;

	[FieldOffset(47)]
	public bool SoftcoreOnly;

	[FieldOffset(48)]
	public bool HardcoreOnly;

	[FieldOffset(49)]
	public bool Unk014;

	[FieldOffset(50)]
	public TString Unk015;

	[FieldOffset(58)]
	public TString Unk016;

	[FieldOffset(66)]
	public TString Unk017;

}
