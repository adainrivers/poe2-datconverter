using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterVarieties
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("MonsterTypes")]
	public TRef MonsterTypesKey;

	[FieldOffset(24)]
	public int Unk002;

	[FieldOffset(28)]
	public int ObjectSize;

	[FieldOffset(32)]
	public int MinimumAttackDistance;

	[FieldOffset(36)]
	public int MaximumAttackDistance;

	[FieldOffset(40)]
	[ElementType(typeof(TString))]
	public TArray ACTFiles;

	[FieldOffset(56)]
	[ElementType(typeof(TString))]
	public TArray AOFiles;

	[FieldOffset(72)]
	public TString BaseMonsterTypeIndex;

	[FieldOffset(80)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TRef))]
	public TArray ModsKeys;

	[FieldOffset(96)]
	public int Unk010;

	[FieldOffset(100)]
	public TString Unk011;

	[FieldOffset(108)]
	public TString Unk012;

	[FieldOffset(116)]
	public int ModelSizeMultiplier;

	[FieldOffset(120)]
	public int Unk014;

	[FieldOffset(124)]
	public int Unk015;

	[FieldOffset(128)]
	public int Unk016;

	[FieldOffset(132)]
	public int Unk017;

	[FieldOffset(136)]
	public int Unk018;

	[FieldOffset(140)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TRef))]
	public TArray TagsKeys;

	[FieldOffset(156)]
	public int ExperienceMultiplier;

	[FieldOffset(160)]
	public int Unk021;

	[FieldOffset(164)]
	public int Unk022;

	[FieldOffset(168)]
	public int Unk023;

	[FieldOffset(172)]
	public int Unk024;

	[FieldOffset(176)]
	public int CriticalStrikeChance;

	[FieldOffset(180)]
	public int Unk026;

	[FieldOffset(184)]
	[ReferenceTable("GrantedEffects")]
	[ElementType(typeof(TRef))]
	public TArray GrantedEffectsKeys;

	[FieldOffset(200)]
	public TString AISFile;

	[FieldOffset(208)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TRef))]
	public TArray ModsKeys2;

	[FieldOffset(224)]
	public TString Stance;

	[FieldOffset(232)]
	public TRef Unk031;

	[FieldOffset(272)]
	public TString Name;

	[FieldOffset(256)]
	public int DamageMultiplier;

	[FieldOffset(260)]
	public int LifeMultiplier;

	[FieldOffset(264)]
	public int AttackSpeed;

	[FieldOffset(268)]
	[ReferenceTable("ItemVisualIdentity")]
	[ElementType(typeof(TRef))]
	public TArray Weapon1_ItemVisualIdentityKeys;

	[FieldOffset(284)]
	[ReferenceTable("ItemVisualIdentity")]
	[ElementType(typeof(TRef))]
	public TArray Weapon2_ItemVisualIdentityKeys;

	[FieldOffset(300)]
	[ReferenceTable("ItemVisualIdentity")]
	public TRef Back_ItemVisualIdentityKey;

	[FieldOffset(316)]
	[ReferenceTable("ItemClasses")]
	public TRef MainHand_ItemClassesKey;

	[FieldOffset(332)]
	[ReferenceTable("ItemClasses")]
	public TRef OffHand_ItemClassesKey;

	[FieldOffset(348)]
	[ReferenceTable("ItemVisualIdentity")]
	public TRef Helmet_ItemVisualIdentityKey;

	[FieldOffset(364)]
	public int Unk042;

	[FieldOffset(368)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray KillSpecificMonsterCount_AchievementItemsKeys;

	[FieldOffset(384)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TRef))]
	public TArray Special_ModsKeys;

	//[FieldOffset(400)]
	//[ReferenceTable("AchievementItems")]
	//[ElementType(typeof(TRef))]
	//public TArray KillRare_AchievementItemsKeys;

	[FieldOffset(416)]
	public TBool Unk046;

	[FieldOffset(417)]
	public int Unk047;

	[FieldOffset(421)]
	public int Unk048;

	[FieldOffset(425)]
	public int Unk049;

	[FieldOffset(429)]
	public int Unk050;

	[FieldOffset(433)]
	public int Unk051;

	[FieldOffset(437)]
	public int Unk052;

	[FieldOffset(441)]
	public short HASH16;

	[FieldOffset(443)]
	public TBool Unk054;

	[FieldOffset(444)]
	public TString Unk055;

	[FieldOffset(452)]
	[ReferenceTable("AchievementItems")]
	public TRef KillWhileOnslaughtIsActive_AchievementItemsKey;

	[FieldOffset(468)]
	[ReferenceTable("MonsterSegments")]
	public TRef MonsterSegmentsKey;

	[FieldOffset(484)]
	[ReferenceTable("MonsterArmours")]
	public TRef MonsterArmoursKey;

	[FieldOffset(500)]
	[ReferenceTable("AchievementItems")]
	public TRef KillWhileTalismanIsActive_AchievementItemsKey;

	[FieldOffset(516)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TRef))]
	public TArray Part1_ModsKeys;

	[FieldOffset(532)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TRef))]
	public TArray Part2_ModsKeys;

	[FieldOffset(548)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TRef))]
	public TArray Endgame_ModsKeys;

	[FieldOffset(564)]
	public TRef Unk063;

	[FieldOffset(580)]
	public int Unk064;

	[FieldOffset(584)]
	public int Unk065;

	[FieldOffset(588)]
	[ElementType(typeof(TRef))]
	public TArray Unk066;

	[FieldOffset(604)]
	[ElementType(typeof(TRef))]
	public TArray Unk067;

	[FieldOffset(620)]
	public int Unk068;

	[FieldOffset(624)]
	public TString SinkAnimation_AOFile;

	[FieldOffset(632)]
	public TBool Unk070;

	[FieldOffset(633)]
	[ElementType(typeof(TRef))]
	public TArray Unk071;

	[FieldOffset(649)]
	public TBool Unk072;

	[FieldOffset(650)]
	public TBool Unk073;

	[FieldOffset(651)]
	public TBool Unk074;

	[FieldOffset(652)]
	public int Unk075;

	[FieldOffset(656)]
	public int Unk076;

	[FieldOffset(660)]
	public float Unk077;

	[FieldOffset(664)]
	public int Unk078;

	[FieldOffset(668)]
	public TString EPKFile;

	[FieldOffset(676)]
	public int Unk080;

	[FieldOffset(680)]
	[ReferenceTable("MonsterConditionalEffectPacks")]
	public TRef MonsterConditionalEffectPacksKey;

	[FieldOffset(696)]
	public TBool Unk082;

	[FieldOffset(697)]
	public TBool Unk083;

	[FieldOffset(698)]
	public int Unk084;

	[FieldOffset(702)]
	public TBool Unk085;

	[FieldOffset(703)]
	public int Unk086;

	[FieldOffset(707)]
	public int Unk087;

	[FieldOffset(711)]
	public int Unk088;

	[FieldOffset(715)]
	public int Unk089;

	[FieldOffset(719)]
	public int Unk090;

	[FieldOffset(723)]
	public int Unk091;

	[FieldOffset(727)]
	[ElementType(typeof(TString))]
	public TArray AddonMonsterTypeIndex;

	[FieldOffset(743)]
	public int Unk093;

	[FieldOffset(747)]
	public int Unk094;

	[FieldOffset(751)]
	public int Unk095;

	[FieldOffset(755)]
	public int Unk096;

	[FieldOffset(759)]
	public int Unk097;

	[FieldOffset(763)]
	public TBool Unk098;

	[FieldOffset(764)]
	public TBool BossHealthBar;

	[FieldOffset(765)]
	public TBool Unk100;

}
