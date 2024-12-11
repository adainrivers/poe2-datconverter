using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CharacterStartQuestState
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("Quest")]
	[ElementType(typeof(TRef))]
	public TArray QuestKeys;

	[FieldOffset(24)]
	[ElementType(typeof(int))]
	public TArray QuestStates;

	[FieldOffset(40)]
	[ElementType(typeof(TRef))]
	public TArray Unk003;

	[FieldOffset(56)]
	[ReferenceTable("MapPins")]
	[ElementType(typeof(TRef))]
	public TArray MapPinsKeys;

	[FieldOffset(72)]
	[ElementType(typeof(int))]
	public TArray Unk005;

	[FieldOffset(88)]
	[ElementType(typeof(TRef))]
	public TArray Unk006;

}
