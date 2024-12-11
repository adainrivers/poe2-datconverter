using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ElderBossArenas
{
	[FieldOffset(0)]
	[ReferenceTable("WorldAreas")]
	public TRef WorldAreasKey;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray AchievementItemsKeys;

}
