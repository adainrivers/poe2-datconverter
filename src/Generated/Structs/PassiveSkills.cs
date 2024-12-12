namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PassiveSkills
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Icon_DDSFile;

	[FieldOffset(16)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Stats;

	[FieldOffset(32)]
	public int Stat1Value;

	[FieldOffset(36)]
	public int Stat2Value;

	[FieldOffset(40)]
	public int Stat3Value;

	[FieldOffset(44)]
	public int Stat4Value;

	[FieldOffset(48)]
	public short PassiveSkillGraphId;

	[FieldOffset(50)]
	public StringReference Name;

	[FieldOffset(58)]
	[ReferenceTable("Characters")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Characters;

	[FieldOffset(74)]
	public TBool IsKeystone;

	[FieldOffset(75)]
	public TBool IsNotable;

	[FieldOffset(76)]
	public StringReference FlavourText;

	[FieldOffset(84)]
	public TBool IsJustIcon;

	[FieldOffset(85)]
	[ReferenceTable("AchievementItems")]
	public TableReference AchievementItem;

	[FieldOffset(101)]
	public TBool IsJewelSocket;

	[FieldOffset(102)]
	[ReferenceTable("Ascendancy")]
	public TableReference AscendancyKey;

	[FieldOffset(118)]
	public TBool IsAscendancyStartingNode;

	[FieldOffset(119)]
	[ReferenceTable("ReminderText")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ReminderStrings;

	[FieldOffset(135)]
	public int SkillPointsGranted;

	[FieldOffset(139)]
	public TBool IsMultipleChoice;

	[FieldOffset(140)]
	public TBool IsMultipleChoiceOption;

	[FieldOffset(141)]
	public int Stat5Value;

	[FieldOffset(145)]
	[ReferenceTable("BuffTemplates")]
	[ElementType(typeof(TableReference))]
	public ArrayReference PassiveSkillBuffs;

	[FieldOffset(161)]
	[ReferenceTable("GrantedEffectsPerLevel")]
	public TableReference GrantedEffectsPerLevel;

	[FieldOffset(177)]
	public TBool IsAnointmentOnly;

	[FieldOffset(178)]
	public int Unk026;

	[FieldOffset(182)]
	public TBool IsExpansion;

	[FieldOffset(183)]
	public TBool IsProxyPassive;

	[FieldOffset(184)]
	[ReferenceTable("PassiveSkillTypes")]
	[EnumName("PassiveSkillTypes")]
	public TEnum SkillType;

	[FieldOffset(188)]
	[ReferenceTable("PassiveSkillMasteryGroups")]
	public TableReference MasteryGroup;

	[FieldOffset(204)]
	[ReferenceTable("AtlasPassiveSkillTreeGroupType")]
	public TableReference Group;

	[FieldOffset(220)]
	[ReferenceTable("SoundEffects")]
	public TableReference SoundEffect;

	[FieldOffset(236)]
	public StringReference Unk033;

	[FieldOffset(244)]
	public int Unk034;

	[FieldOffset(248)]
	public int Unk035;

	[FieldOffset(252)]
	public int Unk036;

	[FieldOffset(256)]
	public int Unk037;

	[FieldOffset(260)]
	public int Unk038;

	[FieldOffset(264)]
	public TBool Unk039;

	[FieldOffset(265)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk040;

	[FieldOffset(281)]
	public int Unk041;

	[FieldOffset(285)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk042;

	[FieldOffset(301)]
	public TBool Unk043;

	[FieldOffset(302)]
	public TableReference Unk044;

	[FieldOffset(318)]
	public TableReference Unk045;

}
