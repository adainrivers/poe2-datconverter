using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BuffVisuals
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString BuffDDSFile;

	[FieldOffset(16)]
	[ElementType(typeof(TString))]
	public TArray EPKFiles1;

	[FieldOffset(32)]
	[ElementType(typeof(TString))]
	public TArray EPKFiles2;

	[FieldOffset(48)]
	[ReferenceTable("PreloadGroups")]
	[ElementType(typeof(TRef))]
	public TArray PreloadGroups;

	[FieldOffset(64)]
	public bool Unk005;

	[FieldOffset(65)]
	public TString BuffName;

	[FieldOffset(73)]
	[ReferenceTable("MiscAnimated")]
	public TRef MiscAnimated1;

	[FieldOffset(89)]
	[ReferenceTable("MiscAnimated")]
	public TRef MiscAnimated2;

	[FieldOffset(105)]
	public TString BuffDescription;

	[FieldOffset(113)]
	public TString EPKFile;

	[FieldOffset(121)]
	public bool HasExtraArt;

	[FieldOffset(122)]
	public TString ExtraArt;

	[FieldOffset(130)]
	[ElementType(typeof(int))]
	public TArray Unk013;

	[FieldOffset(146)]
	[ElementType(typeof(TString))]
	public TArray EPKFiles;

	[FieldOffset(162)]
	[ReferenceTable("BuffVisualOrbs")]
	[ElementType(typeof(TRef))]
	public TArray BuffVisualOrbs;

	[FieldOffset(178)]
	[ReferenceTable("MiscAnimated")]
	public TRef MiscAnimated3;

	[FieldOffset(194)]
	public TRef Unk017;

	[FieldOffset(210)]
	public TString Unk018;

}
