using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Labyrinths
{
	[FieldOffset(0)]
	public int Tier;

	[FieldOffset(4)]
	public TString Name;

	[FieldOffset(12)]
	[ReferenceTable("BaseItemTypes")]
	public TRef OfferingItem;

	[FieldOffset(28)]
	[ReferenceTable("QuestFlags")]
	public TRef QuestFlag;

	[FieldOffset(44)]
	[ReferenceTable("LabyrinthTrials")]
	[ElementType(typeof(TRef))]
	public TArray RequiredTrials;

	[FieldOffset(60)]
	public int AreaLevel;

	[FieldOffset(64)]
	public int Unk006;

	[FieldOffset(68)]
	[ReferenceTable("Words")]
	public TRef JewelReward;

	[FieldOffset(84)]
	[ElementType(typeof(int))]
	public TArray Unk008;

	[FieldOffset(100)]
	[ElementType(typeof(int))]
	public TArray Unk009;

	[FieldOffset(116)]
	public int MinLevel;

	[FieldOffset(120)]
	public int Unk011;

	[FieldOffset(124)]
	public int Unk012;

	[FieldOffset(128)]
	[ReferenceTable("ClientStrings")]
	public TRef CraftingFontDescription;

}
