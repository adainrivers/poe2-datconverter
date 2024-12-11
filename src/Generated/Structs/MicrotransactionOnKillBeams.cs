using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MicrotransactionOnKillBeams
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TRef Unk001;

	[FieldOffset(24)]
	public TString Unk002;

	[FieldOffset(32)]
	public TString Unk003;

	[FieldOffset(40)]
	public TString Unk004;

	[FieldOffset(48)]
	public TBool Unk005;

	[FieldOffset(49)]
	public TRef Unk006;

}
