namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ProjectilesArtVariations
{
	[FieldOffset(0)]
	public StringReference Projectile;

	[FieldOffset(8)]
	public int Variant;

	[FieldOffset(12)]
	[ElementType(typeof(int))]
	public ArrayReference Unk002;

	[FieldOffset(28)]
	public int Unk003;

	[FieldOffset(32)]
	public TableReference Unk004;

}
