using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HideoutDoodads
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItemTypesKey;

	[FieldOffset(16)]
	[ElementType(typeof(TString))]
	public TArray Variation_AOFiles;

	[FieldOffset(32)]
	public bool IsNonMasterDoodad;

	[FieldOffset(33)]
	public TString InheritsFrom;

	[FieldOffset(41)]
	public bool Unk004;

	[FieldOffset(42)]
	public bool IsCraftingBench;

	[FieldOffset(43)]
	[ReferenceTable("HideoutDoodadTags")]
	[ElementType(typeof(TRef))]
	public TArray Tags;

	[FieldOffset(59)]
	public bool Unk007;

	[FieldOffset(60)]
	public TRef Unk008;

	[FieldOffset(76)]
	[ReferenceTable("HideoutDoodadCategory")]
	public TRef Category;

	[FieldOffset(92)]
	public int Unk010;

	[FieldOffset(96)]
	public bool Unk011;

	[FieldOffset(97)]
	public TRef Unk012;

	[FieldOffset(113)]
	public bool Unk013;

	[FieldOffset(114)]
	public TRef Unk014;

	[FieldOffset(130)]
	[ElementType(typeof(TString))]
	public TArray Unk015;

	[FieldOffset(146)]
	public int Unk016;

	[FieldOffset(150)]
	public int Unk017;

	[FieldOffset(154)]
	public bool Unk018;

	[FieldOffset(155)]
	public bool Unk019;

}
