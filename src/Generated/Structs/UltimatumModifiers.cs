using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct UltimatumModifiers
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("UltimatumModifierTypes")]
	[ElementType(typeof(TRef))]
	public TArray Types;

	[FieldOffset(24)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TRef))]
	public TArray ExtraMods;

	[FieldOffset(40)]
	[ReferenceTable("UltimatumModifierTypes")]
	[ElementType(typeof(TRef))]
	public TArray TypesFiltered;

	[FieldOffset(56)]
	[ReferenceTable("DaemonSpawningData")]
	public TRef DaemonSpawningData;

	[FieldOffset(72)]
	[ReferenceTable("UltimatumModifiers")]
	public TRef PreviousTier;

	[FieldOffset(80)]
	public TBool Unk006;

	[FieldOffset(81)]
	public int Radius;

	[FieldOffset(85)]
	public TString Name;

	[FieldOffset(93)]
	public TString Icon;

	[FieldOffset(101)]
	public int HASH16;

	[FieldOffset(105)]
	[ReferenceTable("UltimatumModifierTypes")]
	[ElementType(typeof(TRef))]
	public TArray TypesExtra;

	[FieldOffset(121)]
	public int MonsterTypesApplyingRuin;

	[FieldOffset(125)]
	[ReferenceTable("MiscAnimated")]
	public TRef MiscAnimated;

	[FieldOffset(141)]
	[ReferenceTable("BuffTemplates")]
	[ElementType(typeof(TRef))]
	public TArray BuffTemplates;

	[FieldOffset(157)]
	public int Tier;

	[FieldOffset(161)]
	public int Unk016;

	[FieldOffset(165)]
	public TString Description;

	[FieldOffset(173)]
	[ElementType(typeof(TString))]
	public TArray MonsterSpawners;

	[FieldOffset(189)]
	public TBool Unk019;

	[FieldOffset(190)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray Achievements;

	[FieldOffset(206)]
	[ReferenceTable("NPCTextAudio")]
	public TRef TextAudio;

	[FieldOffset(222)]
	[ReferenceTable("Mods")]
	public TRef UniqueMapMod;

}
