using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ClientStrings
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Text;

	[FieldOffset(16)]
	public TString XBoxText;

	[FieldOffset(24)]
	public TString XBoxText2;

	[FieldOffset(32)]
	public int HASH32;

	[FieldOffset(36)]
	public TString PlaystationText;

}
