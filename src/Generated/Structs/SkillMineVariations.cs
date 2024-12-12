namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SkillMineVariations
{
	[FieldOffset(0)]
	public int SkillMinesKey;

	[FieldOffset(4)]
	public int Unk001;

	[FieldOffset(8)]
	[ReferenceTable("MiscObjects")]
	public TableReference MiscObject;

}
