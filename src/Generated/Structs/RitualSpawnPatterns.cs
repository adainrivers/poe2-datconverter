namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct RitualSpawnPatterns
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	[ElementType(typeof(StringReference))]
	public ArrayReference SpawnOrder;

	[FieldOffset(28)]
	public TBool Unk003;

}
