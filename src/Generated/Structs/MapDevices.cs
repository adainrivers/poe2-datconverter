using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapDevices
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("MiscObjects")]
	public TRef MiscObject;

	[FieldOffset(24)]
	public int Unk002;

	[FieldOffset(28)]
	public TString Unk003;

	[FieldOffset(36)]
	public TString Unk004;

	[FieldOffset(44)]
	[ElementType(typeof(int))]
	public TArray Unk005;

	[FieldOffset(60)]
	public TBool Unk006;

	[FieldOffset(61)]
	public int Unk007;

	[FieldOffset(65)]
	public TBool Unk008;

	[FieldOffset(66)]
	public int Unk009;

	[FieldOffset(70)]
	public TBool Unk010;

	[FieldOffset(71)]
	public float Unk011;

	[FieldOffset(75)]
	public int Unk012;

	[FieldOffset(79)]
	public int Unk013;

	[FieldOffset(83)]
	public int Unk014;

	[FieldOffset(87)]
	public int Unk015;

	[FieldOffset(91)]
	public TBool Unk016;

	[FieldOffset(92)]
	public TBool Unk017;

	[FieldOffset(93)]
	public TBool Unk018;

}
