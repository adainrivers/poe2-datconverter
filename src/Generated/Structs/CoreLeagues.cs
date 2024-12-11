using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CoreLeagues
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TBool Unk001;

	[FieldOffset(9)]
	public TBool Unk002;

	[FieldOffset(10)]
	[ReferenceTable("Stats")]
	public TRef Unk003;

	[FieldOffset(26)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray Unk004;

	[FieldOffset(42)]
	[ReferenceTable("Stats")]
	public TRef Unk005;

	[FieldOffset(58)]
	[ReferenceTable("Stats")]
	public TRef Unk006;

	[FieldOffset(74)]
	[ReferenceTable("Stats")]
	public TRef Unk007;

	[FieldOffset(90)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray Unk008;

	[FieldOffset(106)]
	[ReferenceTable("Stats")]
	public TRef Unk009;

	[FieldOffset(122)]
	public TRef Unk010;

	[FieldOffset(138)]
	public int Unk011;

	[FieldOffset(142)]
	public TBool Unk012;

	[FieldOffset(143)]
	[ReferenceTable("Stats")]
	public TRef Unk013;

	[FieldOffset(159)]
	public TBool Unk014;

	[FieldOffset(160)]
	public TBool Unk015;

	[FieldOffset(161)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray Unk016;

}
