using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DroneBaseTypes
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseType;

	[FieldOffset(16)]
	[ReferenceTable("DroneTypes")]
	public TRef Type;

	[FieldOffset(32)]
	public int Charges;

	[FieldOffset(36)]
	public int Duration;

	[FieldOffset(40)]
	public int EnemyLimit;

	[FieldOffset(44)]
	[ReferenceTable("BuffVisuals")]
	public TRef Visual;

	[FieldOffset(60)]
	public int Empowerment;

	[FieldOffset(64)]
	[ReferenceTable("AchievementItems")]
	public TRef UseAchievement;

	[FieldOffset(80)]
	public bool CreatedViaPowerCore;

}
