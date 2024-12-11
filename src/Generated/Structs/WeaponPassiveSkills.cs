using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct WeaponPassiveSkills
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int Tier;

	[FieldOffset(12)]
	[ReferenceTable("Mods")]
	public TRef Mod;

	[FieldOffset(28)]
	[ElementType(typeof(int))]
	public TArray Unk003;

	[FieldOffset(44)]
	[ElementType(typeof(int))]
	public TArray Unk004;

	[FieldOffset(60)]
	public TString Icon;

	[FieldOffset(68)]
	[ReferenceTable("WeaponPassiveSkillTypes")]
	public TRef Type;

	[FieldOffset(84)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray Achievements;

}
