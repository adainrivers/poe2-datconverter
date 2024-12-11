using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterMapBossDifficulty
{
	[FieldOffset(0)]
	public int MapLevel;

	[FieldOffset(4)]
	public int Stat1Value;

	[FieldOffset(8)]
	public int Stat2Value;

	[FieldOffset(12)]
	[ReferenceTable("Stats")]
	public TRef StatsKey1;

	[FieldOffset(28)]
	[ReferenceTable("Stats")]
	public TRef StatsKey2;

	[FieldOffset(44)]
	[ReferenceTable("Stats")]
	public TRef StatsKey3;

	[FieldOffset(60)]
	public int Stat3Value;

	[FieldOffset(64)]
	[ReferenceTable("Stats")]
	public TRef StatsKey4;

	[FieldOffset(80)]
	public int Stat4Value;

	[FieldOffset(84)]
	[ReferenceTable("Stats")]
	public TRef StatsKey5;

	[FieldOffset(100)]
	public int Stat5Value;

}
