using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CharacterPanelDescriptionModes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Unk001;

	[FieldOffset(16)]
	public TString FormatString_Positive;

	[FieldOffset(24)]
	public TString FormatString_Negative;

}
