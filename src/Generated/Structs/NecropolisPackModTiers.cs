namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NecropolisPackModTiers
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Icon;

	[FieldOffset(16)]
	public StringReference Name;

	[FieldOffset(24)]
	[ElementType(typeof(StringReference))]
	public ArrayReference TextColours;

	[FieldOffset(40)]
	public TBool SpecialTier;

}
