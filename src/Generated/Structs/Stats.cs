namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Stats
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public TBool Unk001;

	[FieldOffset(9)]
	public TBool IsLocal;

	[FieldOffset(10)]
	public TBool IsWeaponLocal;

	[FieldOffset(11)]
	[ReferenceTable("StatSemantics")]
	[EnumName("StatSemantics")]
	public TEnum Semantics;

	[FieldOffset(15)]
	public StringReference Text;

	[FieldOffset(23)]
	public TBool Unk006;

	[FieldOffset(24)]
	public TBool IsVirtual;

	[FieldOffset(25)]
	[ReferenceTable("Stats")]
	public TableReference MainHandAlias_StatsKey;

	[FieldOffset(33)]
	[ReferenceTable("Stats")]
	public TableReference OffHandAlias_StatsKey;

	[FieldOffset(41)]
	public TBool Unk010;

	[FieldOffset(42)]
	public int HASH32;

	[FieldOffset(46)]
	[ReferenceTable("ActiveSkills")]
	[ElementType(typeof(StringReference))]
	public ArrayReference BelongsActiveSkillsKey;

	[FieldOffset(62)]
	[ReferenceTable("PassiveSkillStatCategories")]
	public TableReference Category;

	[FieldOffset(78)]
	public TBool Unk014;

	[FieldOffset(79)]
	public TBool Unk015;

	[FieldOffset(80)]
	public TBool IsScalable;

	[FieldOffset(81)]
	[ReferenceTable("VirtualStatContextFlags")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ContextFlags;

	[FieldOffset(97)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk018;

}
