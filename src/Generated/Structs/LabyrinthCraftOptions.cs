namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LabyrinthCraftOptions
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("LabyrinthCraftOptionFamily")]
	[EnumName("LabyrinthCraftOptionFamily")]
	public TEnum CraftFamily;

	[FieldOffset(12)]
	public StringReference Text;

	[FieldOffset(20)]
	public StringReference Script;

	[FieldOffset(28)]
	public StringReference ScriptArgument;

	[FieldOffset(36)]
	public short HASH16;

	[FieldOffset(38)]
	public TBool Unk006;

	[FieldOffset(39)]
	[ReferenceTable("LabyrinthCraftOptionTiers")]
	public TableReference Tier;

	[FieldOffset(55)]
	public TBool Unk008;

	[FieldOffset(56)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Achievement;

	[FieldOffset(72)]
	public TBool Unk010;

	[FieldOffset(73)]
	public TableReference Unk011;

	[FieldOffset(89)]
	public int Unk012;

}
