using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NecropolisPackModTiers
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Icon;

	[FieldOffset(16)]
	public TString Name;

	[FieldOffset(24)]
	[ElementType(typeof(TString))]
	public TArray TextColours;

	[FieldOffset(40)]
	public TBool SpecialTier;

}
