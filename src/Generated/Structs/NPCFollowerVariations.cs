namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NPCFollowerVariations
{
	[FieldOffset(0)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference MonsterVarietiesKey;

	[FieldOffset(16)]
	[ReferenceTable("MiscAnimated")]
	public TableReference MiscAnimatedKey0;

	[FieldOffset(32)]
	[ReferenceTable("MiscAnimated")]
	public TableReference MiscAnimatedKey1;

	[FieldOffset(48)]
	public TBool Unk003;

	[FieldOffset(49)]
	public TBool Unk004;

	[FieldOffset(50)]
	public int Unk005;

	[FieldOffset(54)]
	public int Unk006;

	[FieldOffset(58)]
	public int Unk007;

	[FieldOffset(62)]
	public int Unk008;

	[FieldOffset(66)]
	public TBool Unk009;

	[FieldOffset(67)]
	public TBool Unk010;

	[FieldOffset(68)]
	[ElementType(typeof(int))]
	public ArrayReference Unk011;

	[FieldOffset(84)]
	[ElementType(typeof(int))]
	public ArrayReference Unk012;

	[FieldOffset(100)]
	public int Unk013;

	[FieldOffset(104)]
	public TBool Unk014;

	[FieldOffset(105)]
	public TBool Unk015;

	[FieldOffset(106)]
	public int Unk016;

}
