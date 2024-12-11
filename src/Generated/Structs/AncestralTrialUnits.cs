using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AncestralTrialUnits
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Name;

	[FieldOffset(16)]
	[ReferenceTable("AncestralTrialTribes")]
	public TRef Tribe;

	[FieldOffset(32)]
	public TString Image;

	[FieldOffset(40)]
	public TString TotemImage;

	[FieldOffset(48)]
	public int HASH16;

	[FieldOffset(52)]
	public int Unk006;

	[FieldOffset(56)]
	public TString Description;

	[FieldOffset(64)]
	public int Unk008;

	[FieldOffset(68)]
	public int Unk009;

	[FieldOffset(72)]
	[ReferenceTable("AncestralTrialUnitPositions")]
	public TRef Position;

}
