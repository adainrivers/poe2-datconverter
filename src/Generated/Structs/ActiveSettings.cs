using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ActiveSettings
{
	[FieldOffset(0)]
	public TString Unk000;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	public int Unk002;

	[FieldOffset(16)]
	public TRef Unk003;

	[FieldOffset(32)]
	public TRef Unk004;

	[FieldOffset(48)]
	public TRef Unk005;

	[FieldOffset(64)]
	public TRef Unk006;

	[FieldOffset(80)]
	public int Unk007;

}
