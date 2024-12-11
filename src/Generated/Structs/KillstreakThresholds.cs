using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct KillstreakThresholds
{
	[FieldOffset(0)]
	public int Kills;

	[FieldOffset(4)]
	[ReferenceTable("MonsterVarieties")]
	public TRef MonsterVarietiesKey;

	[FieldOffset(20)]
	[ReferenceTable("AchievementItems")]
	public TRef AchievementItemsKey;

}
