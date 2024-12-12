using System;

namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CharacterStartQuestState
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("Quest")]
	[ElementType(typeof(TableReference))]
	public ArrayReference QuestKeys;

	[FieldOffset(24)]
    [ReferenceTable("QuestStates")]
    [ElementType(typeof(TableReference))]
	public ArrayReference QuestStates;

	[FieldOffset(40)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk003;

	[FieldOffset(56)]
	[ReferenceTable("MapPins")]
	[ElementType(typeof(TableReference))]
	public ArrayReference MapPinsKeys;

	[FieldOffset(72)]
	[ElementType(typeof(int))]
	public ArrayReference Unk005;

	[FieldOffset(88)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk006;

}
