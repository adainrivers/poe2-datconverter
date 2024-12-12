namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistChokepointFormation
{
	[FieldOffset(0)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference Unk000;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	[ElementType(typeof(int))]
	public ArrayReference Unk002;

	[FieldOffset(36)]
	[ReferenceTable("GrantedEffects")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk003;

	[FieldOffset(52)]
	[ReferenceTable("GrantedEffects")]
	public TableReference Unk004;

	[FieldOffset(68)]
	public int Unk005;

	[FieldOffset(72)]
	public TBool Unk006;

	[FieldOffset(73)]
	public int Unk007;

	[FieldOffset(77)]
	public int Unk008;

	[FieldOffset(81)]
	public int Unk009;

	[FieldOffset(85)]
	public int Unk010;

}
