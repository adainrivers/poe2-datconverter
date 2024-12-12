namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemisedVisualEffect
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference EffectBaseType;

	[FieldOffset(16)]
	[ReferenceTable("ItemVisualEffect")]
	public TableReference VisualEffect;

	[FieldOffset(32)]
	[ReferenceTable("ItemVisualIdentity")]
	public TableReference VisualIdentity;

	[FieldOffset(48)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Stats;

	[FieldOffset(64)]
	[ReferenceTable("ItemClasses")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ItemClasses;

	[FieldOffset(80)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk005;

	[FieldOffset(96)]
	public TBool Unk006;

	[FieldOffset(97)]
	[ElementType(typeof(int))]
	public ArrayReference Unk007;

	[FieldOffset(113)]
	[ElementType(typeof(int))]
	public ArrayReference Unk008;

	[FieldOffset(129)]
	public TBool Unk009;

	[FieldOffset(130)]
	[ElementType(typeof(int))]
	public ArrayReference Unk010;

	[FieldOffset(146)]
	public TBool Unk011;

	[FieldOffset(147)]
	[ElementType(typeof(int))]
	public ArrayReference Unk012;

	[FieldOffset(163)]
	[ElementType(typeof(int))]
	public ArrayReference Unk013;

	[FieldOffset(179)]
	[ElementType(typeof(int))]
	public ArrayReference Unk014;

	[FieldOffset(195)]
	[ElementType(typeof(int))]
	public ArrayReference Unk015;

	[FieldOffset(211)]
	public TableReference Unk016;

	[FieldOffset(227)]
	public TBool Unk017;

	[FieldOffset(228)]
	public TableReference Unk018;

}
