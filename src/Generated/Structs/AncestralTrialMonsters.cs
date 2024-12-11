using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AncestralTrialMonsters
{
	[FieldOffset(0)]
	public TRef Unk000;

	[FieldOffset(16)]
	[ReferenceTable("MonsterVarieties")]
	public TRef Monster;

	[FieldOffset(32)]
	public TRef Unk002;

	[FieldOffset(48)]
	public int Unk003;

	[FieldOffset(52)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray Achievement;

	[FieldOffset(68)]
	public TBool Unk005;

	[FieldOffset(69)]
	public TBool Unk006;

	[FieldOffset(70)]
	public TBool Unk007;

	[FieldOffset(71)]
	public TBool Unk008;

}
