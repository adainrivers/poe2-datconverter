using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SocketNotches
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Description;

	[FieldOffset(16)]
	public TString RedSocketImage;

	[FieldOffset(24)]
	public TString BlueSocketImage;

	[FieldOffset(32)]
	public TString GreenSocketImage;

}
