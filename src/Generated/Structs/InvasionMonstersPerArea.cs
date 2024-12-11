using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct InvasionMonstersPerArea
{
	[FieldOffset(0)]
	[ReferenceTable("WorldAreas")]
	public TRef WorldAreasKey;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	[ElementType(typeof(int))]
	public TArray Unk002;

	[FieldOffset(36)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TRef))]
	public TArray MonsterVarietiesKeys1;

	[FieldOffset(52)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TRef))]
	public TArray MonsterVarietiesKeys2;

	[FieldOffset(68)]
	public int Unk005;

	[FieldOffset(72)]
	public int Unk006;

	[FieldOffset(76)]
	public int Unk007;

	[FieldOffset(80)]
	public int Unk008;

}
