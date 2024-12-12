namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NPCTalk
{
	[FieldOffset(0)]
	[ReferenceTable("NPCs")]
	public TableReference NPCKey;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	public StringReference DialogueOption;

	[FieldOffset(28)]
	[ElementType(typeof(int))]
	public ArrayReference Unk003;

	[FieldOffset(44)]
	[ElementType(typeof(int))]
	public ArrayReference Unk004;

	[FieldOffset(60)]
	[ElementType(typeof(int))]
	public ArrayReference Unk005;

	[FieldOffset(76)]
	public StringReference Script;

	[FieldOffset(84)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference TextAudio;

	[FieldOffset(100)]
	[ReferenceTable("NPCTalkCategory")]
	public TableReference Category;

	[FieldOffset(116)]
	[ReferenceTable("QuestRewardOffers")]
	public TableReference QuestRewardOffersKey;

	[FieldOffset(132)]
	[ReferenceTable("QuestFlags")]
	public TableReference QuestFlag;

	[FieldOffset(148)]
	[ReferenceTable("NPCTextAudio")]
	[ElementType(typeof(TableReference))]
	public ArrayReference NPCTextAudioKeys;

	[FieldOffset(164)]
	public StringReference Script2;

	[FieldOffset(172)]
	public TBool Unk013;

	[FieldOffset(173)]
	public TBool Unk014;

	[FieldOffset(174)]
	[ElementType(typeof(int))]
	public ArrayReference Unk015;

	[FieldOffset(190)]
	[ElementType(typeof(int))]
	public ArrayReference Unk016;

	[FieldOffset(206)]
	public int Unk017;

	[FieldOffset(210)]
	[ElementType(typeof(int))]
	public ArrayReference Unk018;

	[FieldOffset(226)]
	public int Unk019;

	[FieldOffset(230)]
	public TBool Unk020;

	[FieldOffset(231)]
	public TableReference Unk021;

	[FieldOffset(247)]
	public int Unk022;

	[FieldOffset(251)]
	public TBool Unk023;

	[FieldOffset(252)]
	public StringReference DialogueOption2;

	[FieldOffset(260)]
	public TableReference Unk025;

	[FieldOffset(276)]
	public TableReference Unk026;

	[FieldOffset(292)]
	public StringReference Unk027;

	[FieldOffset(300)]
	public int Unk028;

	[FieldOffset(304)]
	public int Unk029;

	[FieldOffset(308)]
	public int Unk030;

	[FieldOffset(312)]
	public int Unk031;

	[FieldOffset(316)]
	public TableReference Unk032;

	[FieldOffset(332)]
	public int Unk033;

	[FieldOffset(336)]
	public TableReference Unk034;

	[FieldOffset(352)]
	public TBool Unk035;

	[FieldOffset(353)]
	public int Unk036;

	[FieldOffset(357)]
	[ReferenceTable("NPCTalk")]
	public TableReference Unk037;

}
