using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AncestralTrialFieldItems
{
	[FieldOffset(0)]
	public TRef Unk000;

	[FieldOffset(16)]
	public TRef Unk001;

	[FieldOffset(32)]
	public int HASH32;

	[FieldOffset(36)]
	public TString Description;

	[FieldOffset(44)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray Achievement;

	[FieldOffset(60)]
	public TRef Unk005;

	[FieldOffset(76)]
	public TRef Unk006;

}
