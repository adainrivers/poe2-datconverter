using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AncestralTrialItems
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int HASH16;

	[FieldOffset(12)]
	public TString Name;

	[FieldOffset(20)]
	public TString Image;

	[FieldOffset(28)]
	public TRef Unk004;

	[FieldOffset(44)]
	public int Unk005;

	[FieldOffset(48)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TRef))]
	public TArray Mods;

	[FieldOffset(64)]
	public TString FlavorText;

	[FieldOffset(72)]
	public int Unk008;

	[FieldOffset(76)]
	[ElementType(typeof(int))]
	public TArray Unk009;

	[FieldOffset(92)]
	public TRef Unk010;

	[FieldOffset(108)]
	public TRef Unk011;

}
