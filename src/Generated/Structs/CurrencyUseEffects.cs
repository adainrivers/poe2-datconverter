using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CurrencyUseEffects
{
	[FieldOffset(0)]
	public TRef Unk000;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	public TString BK2File;

	[FieldOffset(28)]
	public TString SoundFile;

	[FieldOffset(36)]
	public bool Unk004;

	[FieldOffset(37)]
	public TString BK2File2;

	[FieldOffset(45)]
	public bool Unk006;

	[FieldOffset(46)]
	public TRef Unk007;

	[FieldOffset(62)]
	public float Unk008;

}
