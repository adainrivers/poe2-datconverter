namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SanctumPersistentEffects
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Stats;

	[FieldOffset(24)]
	[ElementType(typeof(int))]
	public ArrayReference StatValues;

	[FieldOffset(40)]
	public StringReference Name;

	[FieldOffset(48)]
	public StringReference Icon;

	[FieldOffset(56)]
	public int Unk005;

	[FieldOffset(60)]
	public TBool Unk006;

	[FieldOffset(61)]
	[ReferenceTable("SanctumPersistentEffectCategories")]
	public TableReference EffectCategory;

	[FieldOffset(77)]
	[ReferenceTable("SanctumPersistentEffects")]
	public TableReference NextEffect;

	[FieldOffset(85)]
	public StringReference Unk009;

	[FieldOffset(93)]
	public StringReference BoonDesc;

	[FieldOffset(101)]
	public StringReference CurseDesc;

	[FieldOffset(109)]
	public int Unk012;

	[FieldOffset(113)]
	public int Unk013;

	[FieldOffset(117)]
	public TBool Unk014;

	[FieldOffset(118)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk015;

	[FieldOffset(134)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Guard;

	[FieldOffset(150)]
	[ReferenceTable("SanctumPersistentEffects")]
	public TableReference FirstEffect;

	[FieldOffset(158)]
	public int Unk018;

	[FieldOffset(162)]
	public int Unk019;

	[FieldOffset(166)]
	public TBool Unk020;

	[FieldOffset(167)]
	public TBool Unk021;

	[FieldOffset(168)]
	public int HASH16;

}
