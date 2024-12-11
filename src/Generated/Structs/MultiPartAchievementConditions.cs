using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MultiPartAchievementConditions
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("MultiPartAchievements")]
	public TRef MultiPartAchievementsKey1;

	[FieldOffset(24)]
	[ReferenceTable("MultiPartAchievements")]
	public TRef MultiPartAchievementsKey2;

	[FieldOffset(40)]
	public int Unk003;

	[FieldOffset(44)]
	public int Unk004;

}
