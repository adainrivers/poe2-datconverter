namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ExpeditionDeals
{
	[FieldOffset(0)]
	public int Id;

	[FieldOffset(4)]
	public StringReference Function;

	[FieldOffset(12)]
	public StringReference Arguments;

	[FieldOffset(20)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference TextAudio;

	[FieldOffset(36)]
	public StringReference Description;

	[FieldOffset(44)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference BuyAchievements;

	[FieldOffset(60)]
	public TableReference Unk006;

	[FieldOffset(76)]
	[ReferenceTable("ExpeditionDealFamilies")]
	[EnumName("ExpeditionDealFamilies")]
	public TEnum DealFamily;

}
