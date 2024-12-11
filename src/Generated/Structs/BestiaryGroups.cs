using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BestiaryGroups
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Description;

	[FieldOffset(16)]
	public TString Illustration;

	[FieldOffset(24)]
	public TString Name;

	[FieldOffset(32)]
	public TString Icon;

	[FieldOffset(40)]
	public TString IconSmall;

	[FieldOffset(48)]
	[ReferenceTable("BestiaryFamilies")]
	public TRef BestiaryFamiliesKey;

	[FieldOffset(64)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray AchievementItemsKeys;

}
