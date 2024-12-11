using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AtlasMemoryLine
{
	[FieldOffset(0)]
	public TString League;

	[FieldOffset(8)]
	public TString League2;

	[FieldOffset(16)]
	public TString StartPointArt;

	[FieldOffset(24)]
	public TString MidPointArt;

	[FieldOffset(32)]
	public TString EndPointArt;

	[FieldOffset(40)]
	public TString PathArt;

}
