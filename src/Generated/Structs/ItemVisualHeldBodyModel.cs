using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemVisualHeldBodyModel
{
	[FieldOffset(0)]
	[ReferenceTable("ItemVisualIdentity")]
	public TRef ItemVisualIdentity;

	[FieldOffset(16)]
	public TString MarauderAnimatedObject;

	[FieldOffset(24)]
	public TString RangerAnimatedObject;

	[FieldOffset(32)]
	public TString WitchAnimatedObject;

	[FieldOffset(40)]
	public TString DuelistAnimatedObject;

	[FieldOffset(48)]
	public TString TemplarAnimatedObject;

	[FieldOffset(56)]
	public TString ShadowAnimatedObject;

	[FieldOffset(64)]
	public TString ScionAnimatedObject;

	[FieldOffset(72)]
	public TString MarauderBone;

	[FieldOffset(80)]
	public TString RangerBone;

	[FieldOffset(88)]
	public TString WitchBone;

	[FieldOffset(96)]
	public TString DuelistBone;

	[FieldOffset(104)]
	public TString TemplarBone;

	[FieldOffset(112)]
	public TString ShadowBone;

	[FieldOffset(120)]
	public TString ScionBone;

}
