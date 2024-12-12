using System;

namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct WorldAreas
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Name;

	[FieldOffset(16)]
	public int Act;

	[FieldOffset(20)]
	public TBool IsTown;

	[FieldOffset(21)]
	public TBool HasWaypoint;

	[FieldOffset(22)]
	[ReferenceTable("WorldAreas")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Connections_WorldAreasKeys;

	[FieldOffset(38)]
	public int AreaLevel;

	[FieldOffset(42)]
	public short HASH16;

	[FieldOffset(44)]
	public int Unk008;

	[FieldOffset(48)]
	public int Unk009;

	[FieldOffset(52)]
	public StringReference LoadingScreen_DDSFile;

	[FieldOffset(60)]
	public TableReference Unk011;

	[FieldOffset(76)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk012;

	[FieldOffset(92)]
	public int Unk013;

	[FieldOffset(96)]
	[ReferenceTable("Topologies")]
	[ElementType(typeof(TableReference))]
	public ArrayReference TopologiesKeys;

	[FieldOffset(112)]
	[ReferenceTable("WorldAreas")]
	public TableReference ParentTown_WorldAreasKey;

	[FieldOffset(120)]
	public int Unk016;

	[FieldOffset(124)]
	public TableReference Unk017;

	[FieldOffset(140)]
	public TableReference Unk018;

	[FieldOffset(156)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Bosses_MonsterVarietiesKeys;

	[FieldOffset(172)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Monsters_MonsterVarietiesKeys;

	[FieldOffset(188)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TableReference))]
	public ArrayReference SpawnWeight_TagsKeys;

	[FieldOffset(204)]
	[ElementType(typeof(int))]
	public ArrayReference SpawnWeight_Values;

	[FieldOffset(220)]
	public TBool IsMapArea;

	[FieldOffset(221)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference FullClear_AchievementItemsKeys;

	[FieldOffset(237)]
	public TableReference Unk025;

	[FieldOffset(253)]
	[ReferenceTable("AchievementItems")]
	public TableReference AchievementItemsKey;

	[FieldOffset(269)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ModsKeys;

	[FieldOffset(285)]
	public int Unk028;

	[FieldOffset(289)]
	[ReferenceTable("WorldAreas")]
	[ElementType(typeof(TableReference))]
	public ArrayReference VaalArea;

	[FieldOffset(305)]
	public TBool Unk030;

	[FieldOffset(306)]
	public int MaxLevel;

	[FieldOffset(310)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TableReference))]
	public ArrayReference AreaTypeTags;

	[FieldOffset(326)]
	public TBool IsHideout;

	[FieldOffset(327)]
	public StringReference Inflection;

	[FieldOffset(335)]
	public int Unk035;

	[FieldOffset(339)]
	public int Unk036;

	[FieldOffset(343)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Tags;

	[FieldOffset(359)]
	public TBool IsVaalArea;

	[FieldOffset(360)]
	public TBool IsLabyrinthAirlock;

	[FieldOffset(361)]
	public TBool IsLabyrinthArea;

	[FieldOffset(362)]
	[ReferenceTable("AchievementItems")]
	public TableReference TwinnedFullClear_AchievementItemsKey;

	[FieldOffset(378)]
	[ReferenceTable("AchievementItems")]
	public TableReference Enter_AchievementItemsKey;

	[FieldOffset(394)]
	public StringReference TSIFile;

	[FieldOffset(402)]
	public TableReference Unk044;

	[FieldOffset(418)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference WaypointActivation_AchievementItemsKeys;

	[FieldOffset(434)]
	public TBool IsUniqueMapArea;

	[FieldOffset(435)]
	public TBool IsLabyrinthBossArea;

	[FieldOffset(436)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference FirstEntry_NPCTextAudioKey;

	[FieldOffset(452)]
	[ReferenceTable("SoundEffects")]
	public TableReference FirstEntry_SoundEffectsKey;

	[FieldOffset(468)]
	[ReferenceTable("NPCs")]
	public StringReference FirstEntry_NPCsKey;

	[FieldOffset(476)]
	public int Unk051;

	[FieldOffset(480)]
	[ReferenceTable("Environments")]
	public TableReference EnvironmentsKey;

	[FieldOffset(496)]
	public int Unk053;

	[FieldOffset(500)]
	public TableReference Unk054;

	[FieldOffset(516)]
	public TBool Unk055;

	[FieldOffset(517)]
	public TBool Unk056;

	[FieldOffset(518)]
	[ReferenceTable("WorldAreas")]
	public TableReference Unk057;

	[FieldOffset(526)]
	public int Unk058;

	[FieldOffset(530)]
	[ElementType(typeof(int))]
	public ArrayReference Unk059;

	[FieldOffset(546)]
	[ReferenceTable("WorldAreaLeagueChances")]
	public TableReference LeagueChance1;

	[FieldOffset(562)]
	public int Unk061;

	[FieldOffset(566)]
	[ReferenceTable("WorldAreaLeagueChances")]
	public TableReference LeagueChance2;

	[FieldOffset(582)]
	public TableReference Unk063;

	[FieldOffset(598)]
	[ReferenceTable("Rulesets")]
	public TableReference Ruleset;

	[FieldOffset(614)]
	public int Unk065;

	[FieldOffset(618)]
	[ReferenceTable("QuestFlags")]
	public TableReference QuestFlag;

	[FieldOffset(634)]
	public int Unk067;

}
