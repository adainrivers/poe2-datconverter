namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SanctumDeferredRewardCategories
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference Item;

	[FieldOffset(16)]
	public StringReference NamePlural;

	[FieldOffset(24)]
	public StringReference ScriptReward;

}
