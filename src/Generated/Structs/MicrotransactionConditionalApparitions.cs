using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MicrotransactionConditionalApparitions
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ElementType(typeof(int))]
	public TArray Unk001;

	[FieldOffset(24)]
	[ElementType(typeof(int))]
	public TArray Unk002;

	[FieldOffset(40)]
	public TRef Unk003;

	[FieldOffset(56)]
	public TRef Unk004;

	[FieldOffset(72)]
	public int Unk005;

	[FieldOffset(76)]
	public TBool Unk006;

	[FieldOffset(77)]
	public int Unk007;

	[FieldOffset(81)]
	public TBool Unk008;

}
