using System;

namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct QuestItems
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference Item;

	[FieldOffset(16)]
	[ReferenceTable("QuestFlags")]
	public TableReference HaveItemQuestFlag;

	[FieldOffset(32)]
	[ReferenceTable("QuestFlags")]
	public TableReference UsedItemQuestFlag;

	[FieldOffset(48)]
	public int Unk003;

	[FieldOffset(52)]
	[ElementType(typeof(int))]
	public ArrayReference Unk004;

	[FieldOffset(68)]
	public TBool Unk005;

	[FieldOffset(69)]
	public TBool Unk006;

	[FieldOffset(70)]
    [ReferenceTable("ClientStrings")]
    public TableReference ItemDescription;

	[FieldOffset(86)]
	[ReferenceTable("ClientStrings")]
    public TableReference ItemFunction;

	[FieldOffset(102)]
	public StringReference Script;

	[FieldOffset(110)]
	public TableReference Unk010;

	[FieldOffset(126)]
	public TableReference Unk011;

	[FieldOffset(142)]
	public int Unk012;

}
