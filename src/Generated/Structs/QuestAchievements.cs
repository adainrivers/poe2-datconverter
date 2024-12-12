using System;

namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct QuestAchievements
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ElementType(typeof(int))]
    [ReferenceTable("QuestStates")]
    public ArrayReference QuestStates;

	[FieldOffset(24)]
	[ElementType(typeof(int))]
	public ArrayReference Unk002;

	[FieldOffset(40)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference AchievementItems;

	[FieldOffset(56)]
	[ReferenceTable("NPCs")]
	[ElementType(typeof(TableReference))]
	public ArrayReference NPCs;

	[FieldOffset(72)]
	public TBool Unk005;

}
