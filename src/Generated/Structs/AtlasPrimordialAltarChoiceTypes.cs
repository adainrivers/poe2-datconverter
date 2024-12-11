using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AtlasPrimordialAltarChoiceTypes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString TopIconEater;

	[FieldOffset(16)]
	public TString BottomIconEater;

	[FieldOffset(24)]
	public TString TopIconExarch;

	[FieldOffset(32)]
	public TString BottomIconExarch;

	[FieldOffset(40)]
	public TString Text;

}
