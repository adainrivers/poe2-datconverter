using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ClientLeagueAction
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TRef Unk001;

	[FieldOffset(24)]
	public int Unk002;

	[FieldOffset(28)]
	public TString GamepadIcon;

}
