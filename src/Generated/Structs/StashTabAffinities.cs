namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct StashTabAffinities
{
	[FieldOffset(0)]
	[ReferenceTable("StashId")]
	[EnumName("StashId")]
	public TEnum SpecializedStash;

	[FieldOffset(4)]
	public StringReference Name;

	[FieldOffset(12)]
	[ReferenceTable("StashId")]
	[EnumName("StashId")]
	[ElementType(typeof(TEnum))]
	public ArrayReference ShowInStashes;

}
