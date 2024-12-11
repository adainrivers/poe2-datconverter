using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemisedVisualEffect
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef EffectBaseType;

	[FieldOffset(16)]
	[ReferenceTable("ItemVisualEffect")]
	public TRef VisualEffect;

	[FieldOffset(32)]
	[ReferenceTable("ItemVisualIdentity")]
	public TRef VisualIdentity;

	[FieldOffset(48)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray Stats;

	[FieldOffset(64)]
	[ReferenceTable("ItemClasses")]
	[ElementType(typeof(TRef))]
	public TArray ItemClasses;

	[FieldOffset(80)]
	[ElementType(typeof(TRef))]
	public TArray Unk005;

	[FieldOffset(96)]
	public TBool Unk006;

	[FieldOffset(97)]
	[ElementType(typeof(int))]
	public TArray Unk007;

	[FieldOffset(113)]
	[ElementType(typeof(int))]
	public TArray Unk008;

	[FieldOffset(129)]
	public TBool Unk009;

	[FieldOffset(130)]
	[ElementType(typeof(int))]
	public TArray Unk010;

	[FieldOffset(146)]
	public TBool Unk011;

	[FieldOffset(147)]
	[ElementType(typeof(int))]
	public TArray Unk012;

	[FieldOffset(163)]
	[ElementType(typeof(int))]
	public TArray Unk013;

	[FieldOffset(179)]
	[ElementType(typeof(int))]
	public TArray Unk014;

	[FieldOffset(195)]
	[ElementType(typeof(int))]
	public TArray Unk015;

	[FieldOffset(211)]
	public TRef Unk016;

	[FieldOffset(227)]
	public TBool Unk017;

	[FieldOffset(228)]
	public TRef Unk018;

}
