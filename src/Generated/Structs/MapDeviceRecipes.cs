using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapDeviceRecipes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TRef))]
	public TArray RecipeItems;

	[FieldOffset(24)]
	[ReferenceTable("WorldAreas")]
	public TRef WorldArea;

	[FieldOffset(40)]
	[ReferenceTable("MicrotransactionPortalVariations")]
	public TRef MicrotransactionPortalVariation;

	[FieldOffset(56)]
	public int AreaLevel;

	[FieldOffset(60)]
	public TRef Unk005;

	[FieldOffset(76)]
	public int Unk006;

	[FieldOffset(80)]
	public bool Unk007;

	[FieldOffset(81)]
	public bool Unk008;

	[FieldOffset(82)]
	public bool Unk009;

	[FieldOffset(83)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray OpenAchievemnts;

	[FieldOffset(99)]
	public bool Unk011;

	[FieldOffset(100)]
	public int Unk012;

	[FieldOffset(104)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TRef))]
	public TArray Unk013;

	[FieldOffset(120)]
	public bool Unk014;

}
