using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AwardDisplay
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Text;

	[FieldOffset(16)]
	public TString BackgroundImage;

	[FieldOffset(24)]
	public int Unk003;

	[FieldOffset(28)]
	public float Unk004;

	[FieldOffset(32)]
	public float Unk005;

	[FieldOffset(36)]
	public TString Unk006;

	[FieldOffset(44)]
	public TString Unk007;

	[FieldOffset(52)]
	public TString ForegroundImage;

	[FieldOffset(60)]
	public TString OGGFile;

	[FieldOffset(68)]
	public TRef Unk010;

	[FieldOffset(84)]
	public int Unk011;

	[FieldOffset(88)]
	public TString Unk012;

	[FieldOffset(96)]
	public TBool Unk013;

}
