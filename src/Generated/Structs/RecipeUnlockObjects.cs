namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct RecipeUnlockObjects
{
	[FieldOffset(0)]
	[ReferenceTable("WorldAreas")]
	public TableReference WorldAreasKey;

	[FieldOffset(16)]
	public StringReference InheritsFrom;

	[FieldOffset(24)]
	public int RecipeId;

}
