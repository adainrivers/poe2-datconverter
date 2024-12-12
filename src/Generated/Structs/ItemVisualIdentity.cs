namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemVisualIdentity
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference DDSFile;

	[FieldOffset(16)]
	public StringReference AOFile;

	[FieldOffset(24)]
	[ReferenceTable("SoundEffects")]
	public TableReference InventorySoundEffect;

	[FieldOffset(40)]
	public short HASH16;

	[FieldOffset(42)]
	public StringReference AOFile2;

	[FieldOffset(50)]
	[ElementType(typeof(StringReference))]
	public ArrayReference MarauderSMFiles;

	[FieldOffset(66)]
	[ElementType(typeof(StringReference))]
	public ArrayReference RangerSMFiles;

	[FieldOffset(82)]
	[ElementType(typeof(StringReference))]
	public ArrayReference WitchSMFiles;

	[FieldOffset(98)]
	[ElementType(typeof(StringReference))]
	public ArrayReference DuelistDexSMFiles;

	[FieldOffset(114)]
	[ElementType(typeof(StringReference))]
	public ArrayReference TemplarSMFiles;

	[FieldOffset(130)]
	[ElementType(typeof(StringReference))]
	public ArrayReference ShadowSMFiles;

	[FieldOffset(146)]
	[ElementType(typeof(StringReference))]
	public ArrayReference ScionSMFiles;

	[FieldOffset(162)]
	public StringReference MarauderShape;

	[FieldOffset(170)]
	public StringReference RangerShape;

	[FieldOffset(178)]
	public StringReference WitchShape;

	[FieldOffset(186)]
	public StringReference DuelistShape;

	[FieldOffset(194)]
	public StringReference TemplarShape;

	[FieldOffset(202)]
	public StringReference ShadowShape;

	[FieldOffset(210)]
	public StringReference ScionShape;

	[FieldOffset(218)]
	public int Unk020;

	[FieldOffset(222)]
	public int Unk021;

	[FieldOffset(226)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Pickup_AchievementItemsKeys;

	[FieldOffset(242)]
	[ElementType(typeof(StringReference))]
	public ArrayReference SMFiles;

	[FieldOffset(258)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Identify_AchievementItemsKeys;

	[FieldOffset(274)]
	public StringReference EPKFile;

	[FieldOffset(282)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Corrupt_AchievementItemsKeys;

	[FieldOffset(298)]
	public TBool IsAlternateArt;

	[FieldOffset(299)]
	public TBool Unk028;

	[FieldOffset(300)]
	[ReferenceTable("AchievementItems")]
	public TableReference CreateCorruptedJewelAchievementItemsKey;

	[FieldOffset(316)]
	public StringReference AnimationLocation;

	[FieldOffset(324)]
	public StringReference Unk031;

	[FieldOffset(332)]
	public StringReference Unk032;

	[FieldOffset(340)]
	public StringReference Unk033;

	[FieldOffset(348)]
	public StringReference Unk034;

	[FieldOffset(356)]
	public StringReference Unk035;

	[FieldOffset(364)]
	public StringReference Unk036;

	[FieldOffset(372)]
	public StringReference Unk037;

	[FieldOffset(380)]
	public StringReference Unk038;

	[FieldOffset(388)]
	public StringReference Unk039;

	[FieldOffset(396)]
	public StringReference Unk040;

	[FieldOffset(404)]
	public StringReference Unk041;

	[FieldOffset(412)]
	public StringReference Unk042;

	[FieldOffset(420)]
	public TBool IsAtlasOfWorldsMapIcon;

	[FieldOffset(421)]
	public TBool IsTier16Icon;

	[FieldOffset(422)]
	[ElementType(typeof(int))]
	public ArrayReference Unk045;

	[FieldOffset(438)]
	public TBool Unk046;

	[FieldOffset(439)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk047;

	[FieldOffset(455)]
	public StringReference Unk048;

	[FieldOffset(463)]
	public int Composition;

	[FieldOffset(467)]
	public TableReference Unk050;

	[FieldOffset(483)]
	public TableReference Unk051;

	[FieldOffset(499)]
	public TableReference Unk052;

	[FieldOffset(515)]
	public TableReference Unk053;

	[FieldOffset(531)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk054;

	[FieldOffset(547)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk055;

	[FieldOffset(563)]
	public TBool Unk056;

}
