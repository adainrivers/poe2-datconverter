using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MicrotransactionOnKillEffects
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TRef Unk001;

	[FieldOffset(24)]
	public TRef Unk002;

	[FieldOffset(40)]
	public TRef Unk003;

	[FieldOffset(56)]
	public int Unk004;

	[FieldOffset(60)]
	public TRef Unk005;

	[FieldOffset(76)]
	public int Unk006;

	[FieldOffset(80)]
	public TRef Unk007;

}
