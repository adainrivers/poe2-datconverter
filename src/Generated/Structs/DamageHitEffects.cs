namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DamageHitEffects
{
	[FieldOffset(0)]
	public int Id;

	[FieldOffset(4)]
	public int Unk001;

	[FieldOffset(8)]
	public int Unk002;

	[FieldOffset(12)]
	[ElementType(typeof(int))]
	public ArrayReference Unk003;

	[FieldOffset(28)]
	[ElementType(typeof(int))]
	public ArrayReference Unk004;

}
