namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SkillTotemVariations
{
	[FieldOffset(0)]
	[ReferenceTable("SkillTotems")]
	[EnumName("SkillTotems")]
	public TEnum SkillTotemsKey;

	[FieldOffset(4)]
	public int TotemSkinId;

	[FieldOffset(8)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference MonsterVarietiesKey;

}
