namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct UltimatumItemisedRewards
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int HASH16;

	[FieldOffset(12)]
	public StringReference RewardText;

	[FieldOffset(20)]
	[ReferenceTable("ItemVisualIdentity")]
	public TableReference ItemVisualIdentityKey;

	[FieldOffset(36)]
	public int RewardType;

	[FieldOffset(40)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference SacrificeItem;

	[FieldOffset(56)]
	public int SacrificeAmount;

	[FieldOffset(60)]
	public StringReference SacrificeText;

	[FieldOffset(68)]
	public TBool Unk008;

	[FieldOffset(69)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference TrialMods;

}
