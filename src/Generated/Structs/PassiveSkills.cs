using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PassiveSkills
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Icon_DDSFile;

	[FieldOffset(16)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray Stats;

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
	public TString Name;

	[FieldOffset(58)]
	[ReferenceTable("Characters")]
	[ElementType(typeof(TRef))]
	public TArray Characters;

	[FieldOffset(74)]
	public bool IsKeystone;

	[FieldOffset(75)]
	public bool IsNotable;

	[FieldOffset(76)]
	public TString FlavourText;

	[FieldOffset(84)]
	public bool IsJustIcon;

	[FieldOffset(85)]
	[ReferenceTable("AchievementItems")]
	public TRef AchievementItem;

	[FieldOffset(101)]
	public bool IsJewelSocket;

	[FieldOffset(102)]
	[ReferenceTable("Ascendancy")]
	public TRef AscendancyKey;

	[FieldOffset(118)]
	public bool IsAscendancyStartingNode;

	[FieldOffset(119)]
	[ReferenceTable("ReminderText")]
	[ElementType(typeof(TRef))]
	public TArray ReminderStrings;

	[FieldOffset(135)]
	public int SkillPointsGranted;

	[FieldOffset(139)]
	public bool IsMultipleChoice;

	[FieldOffset(140)]
	public bool IsMultipleChoiceOption;

	[FieldOffset(141)]
	public int Stat5Value;

	[FieldOffset(145)]
	[ReferenceTable("BuffTemplates")]
	[ElementType(typeof(TRef))]
	public TArray PassiveSkillBuffs;

	[FieldOffset(161)]
	[ReferenceTable("GrantedEffectsPerLevel")]
	public TRef GrantedEffectsPerLevel;

	[FieldOffset(177)]
	public bool IsAnointmentOnly;

	[FieldOffset(178)]
	public int Unk026;

	[FieldOffset(182)]
	public bool IsExpansion;

	[FieldOffset(183)]
	public bool IsProxyPassive;

	[FieldOffset(184)]
	[ReferenceTable("PassiveSkillTypes")]
	[EnumName("PassiveSkillTypes")]
	public TEnum SkillType;

	[FieldOffset(188)]
	[ReferenceTable("PassiveSkillMasteryGroups")]
	public TRef MasteryGroup;

	[FieldOffset(204)]
	[ReferenceTable("AtlasPassiveSkillTreeGroupType")]
	public TRef Group;

	[FieldOffset(220)]
	[ReferenceTable("SoundEffects")]
	public TRef SoundEffect;

	[FieldOffset(236)]
	public TString Unk033;

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
	public bool Unk039;

	[FieldOffset(265)]
	[ElementType(typeof(TRef))]
	public TArray Unk040;

	[FieldOffset(281)]
	public int Unk041;

	[FieldOffset(285)]
	[ElementType(typeof(TRef))]
	public TArray Unk042;

	[FieldOffset(301)]
	public bool Unk043;

	[FieldOffset(302)]
	public TRef Unk044;

	[FieldOffset(318)]
	public TRef Unk045;

}
