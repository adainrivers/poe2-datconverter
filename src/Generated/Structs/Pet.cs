namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Pet
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemTypesKey;

	[FieldOffset(24)]
	public int HASH16;

	[FieldOffset(28)]
	public int HASH32;

	[FieldOffset(32)]
	public int Unk004;

	[FieldOffset(36)]
	public TBool Unk005;

	[FieldOffset(37)]
	public TBool Unk006;

	[FieldOffset(38)]
	[ElementType(typeof(int))]
	public ArrayReference Unk007;

	[FieldOffset(54)]
	public TableReference Unk008;

	[FieldOffset(70)]
	[ReferenceTable("GrantedEffectsPerLevel")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Skills;

	[FieldOffset(86)]
	public int Unk010;

	[FieldOffset(90)]
	public TBool Unk011;

	[FieldOffset(91)]
	public TableReference Unk012;

	[FieldOffset(107)]
	public TBool Unk013;

}
