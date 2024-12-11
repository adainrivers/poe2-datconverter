using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Tutorial
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString UIFile;

	[FieldOffset(16)]
	[ReferenceTable("ClientStrings")]
	public TRef ClientString;

	[FieldOffset(32)]
	public bool IsEnabled;

	[FieldOffset(33)]
	public int Unk004;

	[FieldOffset(37)]
	[ElementType(typeof(int))]
	public TArray Unk005;

	[FieldOffset(53)]
	public TRef Unk006;

	[FieldOffset(69)]
	public int Unk007;

	[FieldOffset(73)]
	[ElementType(typeof(int))]
	public TArray Unk008;

	[FieldOffset(89)]
	public bool Unk009;

	[FieldOffset(90)]
	public bool Unk010;

	[FieldOffset(91)]
	public int Unk011;

}
