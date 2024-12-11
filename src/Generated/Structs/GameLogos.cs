using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GameLogos
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString LogoIntl;

	[FieldOffset(16)]
	public TString LogoTW;

}
