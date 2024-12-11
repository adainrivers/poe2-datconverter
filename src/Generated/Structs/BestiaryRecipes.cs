using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BestiaryRecipes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Description;

	[FieldOffset(16)]
	[ReferenceTable("BestiaryRecipeComponent")]
	[ElementType(typeof(TRef))]
	public TArray BestiaryRecipeComponentKeys;

	[FieldOffset(32)]
	public TString Notes;

	[FieldOffset(40)]
	[ReferenceTable("BestiaryRecipeCategories")]
	public TRef Category;

	[FieldOffset(56)]
	public bool Unk005;

	[FieldOffset(57)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray Achievements;

	[FieldOffset(73)]
	public bool Unk007;

	[FieldOffset(74)]
	public int Unk008;

	[FieldOffset(78)]
	public int Unk009;

	[FieldOffset(82)]
	public int GameMode;

	[FieldOffset(86)]
	[ReferenceTable("Mods")]
	public TRef FlaskMod;

}
