using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct OnKillAchievements
{
	[FieldOffset(0)]
	[ReferenceTable("MonsterVarieties")]
	public TRef MonsterVarietiesKey;

	[FieldOffset(16)]
	[ReferenceTable("GameStats")]
	public TRef GameStat;

}
