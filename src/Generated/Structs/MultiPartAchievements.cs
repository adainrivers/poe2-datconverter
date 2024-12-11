using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MultiPartAchievements
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	[ReferenceTable("AchievementItems")]
	public TRef AchievementItemsKey;

	[FieldOffset(28)]
	public int Unk003;

	[FieldOffset(32)]
	public TBool Unk004;

	[FieldOffset(33)]
	public TBool Unk005;

	[FieldOffset(34)]
	public int Unk006;

}
