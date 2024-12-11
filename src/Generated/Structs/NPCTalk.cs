using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NPCTalk
{
	[FieldOffset(0)]
	[ReferenceTable("NPCs")]
	public TRef NPCKey;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	public TString DialogueOption;

	[FieldOffset(28)]
	[ElementType(typeof(int))]
	public TArray Unk003;

	[FieldOffset(44)]
	[ElementType(typeof(int))]
	public TArray Unk004;

	[FieldOffset(60)]
	[ElementType(typeof(int))]
	public TArray Unk005;

	[FieldOffset(76)]
	public TString Script;

	[FieldOffset(84)]
	[ReferenceTable("NPCTextAudio")]
	public TRef TextAudio;

	[FieldOffset(100)]
	[ReferenceTable("NPCTalkCategory")]
	public TRef Category;

	[FieldOffset(116)]
	[ReferenceTable("QuestRewardOffers")]
	public TRef QuestRewardOffersKey;

	[FieldOffset(132)]
	[ReferenceTable("QuestFlags")]
	public TRef QuestFlag;

	[FieldOffset(148)]
	[ReferenceTable("NPCTextAudio")]
	[ElementType(typeof(TRef))]
	public TArray NPCTextAudioKeys;

	[FieldOffset(164)]
	public TString Script2;

	[FieldOffset(172)]
	public bool Unk013;

	[FieldOffset(173)]
	public bool Unk014;

	[FieldOffset(174)]
	[ElementType(typeof(int))]
	public TArray Unk015;

	[FieldOffset(190)]
	[ElementType(typeof(int))]
	public TArray Unk016;

	[FieldOffset(206)]
	public int Unk017;

	[FieldOffset(210)]
	[ElementType(typeof(int))]
	public TArray Unk018;

	[FieldOffset(226)]
	public int Unk019;

	[FieldOffset(230)]
	public bool Unk020;

	[FieldOffset(231)]
	public TRef Unk021;

	[FieldOffset(247)]
	public int Unk022;

	[FieldOffset(251)]
	public bool Unk023;

	[FieldOffset(252)]
	public TString DialogueOption2;

	[FieldOffset(260)]
	public TRef Unk025;

	[FieldOffset(276)]
	public TRef Unk026;

	[FieldOffset(292)]
	public TString Unk027;

	[FieldOffset(300)]
	public int Unk028;

	[FieldOffset(304)]
	public int Unk029;

	[FieldOffset(308)]
	public int Unk030;

	[FieldOffset(312)]
	public int Unk031;

	[FieldOffset(316)]
	public TRef Unk032;

	[FieldOffset(332)]
	public int Unk033;

	[FieldOffset(336)]
	public TRef Unk034;

	[FieldOffset(352)]
	public bool Unk035;

	[FieldOffset(353)]
	public int Unk036;

	[FieldOffset(357)]
	[ReferenceTable("NPCTalk")]
	public TRef Unk037;

}
