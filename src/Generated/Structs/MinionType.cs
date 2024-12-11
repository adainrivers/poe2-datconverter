using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MinionType
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TRef Unk001;

	[FieldOffset(24)]
	public TRef Unk002;

	[FieldOffset(40)]
	public TBool Unk003;

	[FieldOffset(41)]
	public TBool Unk004;

	[FieldOffset(42)]
	public int Unk005;

	[FieldOffset(46)]
	public TBool Unk006;

	[FieldOffset(47)]
	public TBool Unk007;

	[FieldOffset(48)]
	public TBool Unk008;

	[FieldOffset(49)]
	public TBool Unk009;

	[FieldOffset(50)]
	public TBool Unk010;

	[FieldOffset(51)]
	public TBool Unk011;

}
