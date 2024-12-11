using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AegisVariations
{
	[FieldOffset(0)]
	public TString Name;

	[FieldOffset(8)]
	public TBool DefendsAgainstPhysical;

	[FieldOffset(9)]
	public TBool DefendsAgainstFire;

	[FieldOffset(10)]
	public TBool DefendsAgainstCold;

	[FieldOffset(11)]
	public TBool DefendsAgainstLightning;

	[FieldOffset(12)]
	public TBool DefendsAgainstChaos;

	[FieldOffset(13)]
	public TRef Unk006;

	[FieldOffset(29)]
	public TRef Unk007;

	[FieldOffset(45)]
	public TRef Unk008;

	[FieldOffset(61)]
	public TRef Unk009;

	[FieldOffset(77)]
	[ElementType(typeof(int))]
	public TArray Unk010;

}
