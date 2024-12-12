namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AchievementItemRewards
{
	[FieldOffset(0)]
	[ReferenceTable("AchievementItems")]
	public TableReference AchievementItemsKey;

	[FieldOffset(16)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemTypesKey;

	[FieldOffset(32)]
	public StringReference Message;

	[FieldOffset(40)]
	public StringReference Id;

}
