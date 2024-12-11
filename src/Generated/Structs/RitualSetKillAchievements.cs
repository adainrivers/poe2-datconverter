using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct RitualSetKillAchievements
{
	[FieldOffset(0)]
	[ReferenceTable("AchievementItems")]
	public TRef Achievement;

	[FieldOffset(16)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TRef))]
	public TArray KillBosses;

}
