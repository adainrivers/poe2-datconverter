namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BuffVisualOrbs
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("BuffVisualOrbTypes")]
	public TableReference BuffVisualOrbTypesKey;

	[FieldOffset(24)]
	[ReferenceTable("BuffVisualOrbArt")]
	[ElementType(typeof(TableReference))]
	public ArrayReference BuffVisualOrbArtKeys;

	[FieldOffset(40)]
	[ReferenceTable("BuffVisualOrbArt")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Player_BuffVisualOrbArtKeys;

	[FieldOffset(56)]
	[ReferenceTable("BuffVisualOrbArt")]
	[ElementType(typeof(TableReference))]
	public ArrayReference BuffVisualOrbArtKeys2;

}
