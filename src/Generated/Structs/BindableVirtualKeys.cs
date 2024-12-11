using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BindableVirtualKeys
{
	[FieldOffset(0)]
	public int KeyCode;

	[FieldOffset(4)]
	public TString Name;

	[FieldOffset(12)]
	public TString Id;

}
