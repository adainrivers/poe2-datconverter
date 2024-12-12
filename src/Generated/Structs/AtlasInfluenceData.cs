namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AtlasInfluenceData
{
	[FieldOffset(0)]
	[ReferenceTable("AtlasInfluenceOutcomes")]
	public TableReference InfluencePack;

	[FieldOffset(16)]
	[ReferenceTable("MonsterPacks")]
	[ElementType(typeof(TableReference))]
	public ArrayReference MonsterPacks;

	[FieldOffset(32)]
	public TableReference Unk002;

	[FieldOffset(48)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk003;

	[FieldOffset(64)]
	public int Unk004;

	[FieldOffset(68)]
	public int Unk005;

	[FieldOffset(72)]
	public int Unk006;

	[FieldOffset(76)]
	public int Unk007;

	[FieldOffset(80)]
	[ElementType(typeof(int))]
	public ArrayReference Unk008;

	[FieldOffset(96)]
	public int Unk009;

	[FieldOffset(100)]
	public int Unk010;

	[FieldOffset(104)]
	public TableReference Unk011;

	[FieldOffset(120)]
	public int Unk012;

	[FieldOffset(124)]
	public int Unk013;

	[FieldOffset(128)]
	public int Unk014;

	[FieldOffset(132)]
	public int Unk015;

	[FieldOffset(136)]
	public TBool Unk016;

	[FieldOffset(137)]
	public TBool Unk017;

	[FieldOffset(138)]
	public TBool Unk018;

	[FieldOffset(139)]
	public TBool Unk019;

}
