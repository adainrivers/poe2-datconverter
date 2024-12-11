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
	public TBool Unk005;

	[FieldOffset(31)]
	public TBool HideAchievementItems;

	[FieldOffset(32)]
	public TBool Unk007;

	[FieldOffset(33)]
	public int MinCompletedItems;

	[FieldOffset(37)]
	public TBool TwoColumnLayout;

	[FieldOffset(38)]
	public TBool ShowItemCompletionsAsOne;

	[FieldOffset(39)]
	public TString Unk011;

	[FieldOffset(47)]
	public TBool SoftcoreOnly;

	[FieldOffset(48)]
	public TBool HardcoreOnly;

	[FieldOffset(49)]
	public TBool Unk014;

	[FieldOffset(50)]
	public TString Unk015;

	[FieldOffset(58)]
	public TString Unk016;

	[FieldOffset(66)]
	public TString Unk017;

}
