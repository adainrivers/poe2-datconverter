namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterProjectileSpell
{
	[FieldOffset(0)]
	public int Id;

	[FieldOffset(4)]
	[ReferenceTable("Projectiles")]
	public TableReference Projectile;

	[FieldOffset(20)]
	[ReferenceTable("Animation")]
	public TableReference Animation;

	[FieldOffset(36)]
	public TBool Unk003;

	[FieldOffset(37)]
	public TBool Unk004;

	[FieldOffset(38)]
	public int Unk005;

	[FieldOffset(42)]
	public TBool Unk006;

}
