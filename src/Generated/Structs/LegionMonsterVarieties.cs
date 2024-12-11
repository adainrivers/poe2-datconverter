using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LegionMonsterVarieties
{
	[FieldOffset(0)]
	[ReferenceTable("MonsterVarieties")]
	public TRef MonsterVarietiesKey;

	[FieldOffset(16)]
	[ReferenceTable("LegionFactions")]
	public TRef LegionFactionsKey;

	[FieldOffset(32)]
	[ReferenceTable("LegionRanks")]
	public TRef LegionRanksKey;

	[FieldOffset(48)]
	public int Unk003;

	[FieldOffset(52)]
	[ReferenceTable("MiscAnimated")]
	[ElementType(typeof(TRef))]
	public TArray MiscAnimatedKey;

	[FieldOffset(68)]
	public int Unk005;

	[FieldOffset(72)]
	public int Unk006;

	[FieldOffset(76)]
	[ElementType(typeof(int))]
	public TArray Unk007;

	[FieldOffset(92)]
	[ElementType(typeof(int))]
	public TArray Unk008;

	[FieldOffset(108)]
	[ElementType(typeof(int))]
	public TArray Unk009;

	[FieldOffset(124)]
	[ElementType(typeof(int))]
	public TArray Unk010;

	[FieldOffset(140)]
	[ElementType(typeof(int))]
	public TArray Unk011;

	[FieldOffset(156)]
	[ElementType(typeof(int))]
	public TArray Unk012;

	[FieldOffset(172)]
	public int Unk013;

	[FieldOffset(176)]
	public int Unk014;

	[FieldOffset(180)]
	[ElementType(typeof(TRef))]
	public TArray Unk015;

	[FieldOffset(196)]
	[ReferenceTable("MonsterVarieties")]
	public TRef MonsterVarietiesKey2;

}
