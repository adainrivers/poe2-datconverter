using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BreachBossLifeScalingPerLevel
{
	[FieldOffset(0)]
	public int MonsterLevel;

	[FieldOffset(4)]
	public int LifeMultiplier;

}
