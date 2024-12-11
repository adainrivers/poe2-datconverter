using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct WindowCursors
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString CursorDefault;

	[FieldOffset(16)]
	public TString CursorClick;

	[FieldOffset(24)]
	public int Unk003;

	[FieldOffset(28)]
	public int Unk004;

	[FieldOffset(32)]
	public TString CursorHover;

	[FieldOffset(40)]
	public TString Description;

	[FieldOffset(48)]
	public TBool IsEnabled;

	[FieldOffset(49)]
	public int Unk008;

}
