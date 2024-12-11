using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterProjectileAttack
{
	[FieldOffset(0)]
	public int Id;

	[FieldOffset(4)]
	[ReferenceTable("Projectiles")]
	public TRef Projectile;

	[FieldOffset(20)]
	public TBool Unk002;

	[FieldOffset(21)]
	public TBool Unk003;

	[FieldOffset(22)]
	public TBool Unk004;

	[FieldOffset(23)]
	public int Unk005;

}
