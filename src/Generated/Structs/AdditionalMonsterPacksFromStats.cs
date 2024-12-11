using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AdditionalMonsterPacksFromStats
{
	[FieldOffset(0)]
	[ReferenceTable("Stats")]
	public TRef StatsKey;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	[ReferenceTable("MonsterPacks")]
	[ElementType(typeof(TRef))]
	public TArray MonsterPacksKeys;

	[FieldOffset(36)]
	public int AdditionalMonsterPacksStatMode;

	[FieldOffset(40)]
	[ReferenceTable("Stats")]
	public TRef PackCountStatsKey;

	[FieldOffset(56)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray StatsKeys;

	[FieldOffset(72)]
	[ElementType(typeof(int))]
	public TArray StatsValues;

	[FieldOffset(88)]
	public int Unk007;

	[FieldOffset(92)]
	[ReferenceTable("Stats")]
	public TRef PackSizeStatsKey;

}
