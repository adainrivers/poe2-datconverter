namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Labyrinths
{
	[FieldOffset(0)]
	public int Tier;

	[FieldOffset(4)]
	public StringReference Name;

	[FieldOffset(12)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference OfferingItem;

	[FieldOffset(28)]
	[ReferenceTable("QuestFlags")]
	public TableReference QuestFlag;

	[FieldOffset(44)]
	[ReferenceTable("LabyrinthTrials")]
	[ElementType(typeof(TableReference))]
	public ArrayReference RequiredTrials;

	[FieldOffset(60)]
	public int AreaLevel;

	[FieldOffset(64)]
	public int Unk006;

	[FieldOffset(68)]
	[ReferenceTable("Words")]
	public TableReference JewelReward;

	[FieldOffset(84)]
	[ElementType(typeof(int))]
	public ArrayReference Unk008;

	[FieldOffset(100)]
	[ElementType(typeof(int))]
	public ArrayReference Unk009;

	[FieldOffset(116)]
	public int MinLevel;

	[FieldOffset(120)]
	public int Unk011;

	[FieldOffset(124)]
	public int Unk012;

	[FieldOffset(128)]
	[ReferenceTable("ClientStrings")]
	public TableReference CraftingFontDescription;

}
