namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct WarbandsPackMonsters
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	public TBool Unk002;

	[FieldOffset(13)]
	public TBool Unk003;

	[FieldOffset(14)]
	public TBool Unk004;

	[FieldOffset(15)]
	public TBool Unk005;

	[FieldOffset(16)]
	public int Unk006;

	[FieldOffset(20)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Tier4_MonsterVarietiesKeys;

	[FieldOffset(36)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Tier3_MonsterVarietiesKeys;

	[FieldOffset(52)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Tier2_MonsterVarietiesKeys;

	[FieldOffset(68)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Tier1_MonsterVarietiesKeys;

	[FieldOffset(84)]
	public StringReference Tier1Name;

	[FieldOffset(92)]
	public StringReference Tier2Name;

	[FieldOffset(100)]
	public StringReference Tier3Name;

	[FieldOffset(108)]
	public StringReference Tier4Name;

	[FieldOffset(116)]
	public StringReference Tier1Art;

	[FieldOffset(124)]
	public StringReference Tier2Art;

	[FieldOffset(132)]
	public StringReference Tier3Art;

	[FieldOffset(140)]
	public StringReference Tier4Art;

}
