namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct IndexableSkillGems
{
	[FieldOffset(0)]
	public int Index;

	[FieldOffset(4)]
	[ReferenceTable("SkillGems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference SkillGem1;

	[FieldOffset(20)]
	public StringReference Name1;

	[FieldOffset(28)]
	[ReferenceTable("SkillGems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference SkillGem2;

	[FieldOffset(44)]
	public StringReference Name2;

	[FieldOffset(52)]
	[ReferenceTable("IndexableSkillGems")]
	public TableReference Unk005;

}
