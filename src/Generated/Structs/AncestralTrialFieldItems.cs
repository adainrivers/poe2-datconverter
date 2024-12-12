namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AncestralTrialFieldItems
{
	[FieldOffset(0)]
	public TableReference Unk000;

	[FieldOffset(16)]
	public TableReference Unk001;

	[FieldOffset(32)]
	public int HASH32;

	[FieldOffset(36)]
	public StringReference Description;

	[FieldOffset(44)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Achievement;

	[FieldOffset(60)]
	public TableReference Unk005;

	[FieldOffset(76)]
	public TableReference Unk006;

}
