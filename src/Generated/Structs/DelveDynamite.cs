using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DelveDynamite
{
	[FieldOffset(0)]
	public int Unk000;

	[FieldOffset(4)]
	[ReferenceTable("Projectiles")]
	public TRef ProjectilesKey;

	[FieldOffset(20)]
	public TRef Unk002;

	[FieldOffset(36)]
	[ReferenceTable("MiscObjects")]
	public TRef Dynamite_MiscObjectsKey;

	[FieldOffset(52)]
	public int Unk004;

	[FieldOffset(56)]
	public int Unk005;

	[FieldOffset(60)]
	public int Unk006;

	[FieldOffset(64)]
	public int Unk007;

	[FieldOffset(68)]
	public int Unk008;

	[FieldOffset(72)]
	public int Unk009;

	[FieldOffset(76)]
	public int Unk010;

	[FieldOffset(80)]
	[ReferenceTable("MiscAnimated")]
	public TRef MiscAnimatedKey;

	[FieldOffset(96)]
	public int Unk012;

}
