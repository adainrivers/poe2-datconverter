using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Ascendancy
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int ClassNo;

	[FieldOffset(12)]
	[ReferenceTable("Characters")]
	[ElementType(typeof(TRef))]
	public TArray Characters;

	[FieldOffset(28)]
	public TString CoordinateRect;

	[FieldOffset(36)]
	public TString RGBFlavourTextColour;

	[FieldOffset(44)]
	public TString Name;

	[FieldOffset(52)]
	public TString FlavourText;

	[FieldOffset(60)]
	public TString OGGFile;

	[FieldOffset(68)]
	public TString PassiveTreeImage;

	[FieldOffset(76)]
	public int Unk009;

	[FieldOffset(80)]
	public int Unk010;

	[FieldOffset(84)]
	public TString BackgroundImage;

}
