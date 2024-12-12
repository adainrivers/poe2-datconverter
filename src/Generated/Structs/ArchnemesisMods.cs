namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ArchnemesisMods
{
	[FieldOffset(0)]
	[ReferenceTable("Mods")]
	public TableReference Mod;

	[FieldOffset(16)]
	public StringReference Name;

	[FieldOffset(24)]
	[ReferenceTable("ArchnemesisModVisuals")]
	public TableReference Visual;

	[FieldOffset(40)]
	[ElementType(typeof(StringReference))]
	public ArrayReference TextStyles;

	[FieldOffset(56)]
	public TBool Unk004;

	[FieldOffset(57)]
	public TBool Unk005;

}
