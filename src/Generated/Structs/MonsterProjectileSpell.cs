using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterProjectileSpell
{
	[FieldOffset(0)]
	public int Id;

	[FieldOffset(4)]
	[ReferenceTable("Projectiles")]
	public TRef Projectile;

	[FieldOffset(20)]
	[ReferenceTable("Animation")]
	public TRef Animation;

	[FieldOffset(36)]
	public bool Unk003;

	[FieldOffset(37)]
	public bool Unk004;

	[FieldOffset(38)]
	public int Unk005;

	[FieldOffset(42)]
	public bool Unk006;

}
