using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Characters
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Name;

	[FieldOffset(16)]
	public TString AOFile;

	[FieldOffset(24)]
	public TString ACTFile;

	[FieldOffset(32)]
	public int BaseMaxLife;

	[FieldOffset(36)]
	public int BaseMaxMana;

	[FieldOffset(40)]
	public int WeaponSpeed;

	[FieldOffset(44)]
	public int MinDamage;

	[FieldOffset(48)]
	public int MaxDamage;

	[FieldOffset(52)]
	public int MaxAttackDistance;

	[FieldOffset(56)]
	public TString Icon;

	[FieldOffset(64)]
	public int IntegerId;

	[FieldOffset(68)]
	public int BaseStrength;

	[FieldOffset(72)]
	public int BaseDexterity;

	[FieldOffset(76)]
	public int BaseIntelligence;

	[FieldOffset(80)]
	[ElementType(typeof(TRef))]
	public TArray Unk015;

	[FieldOffset(96)]
	public TString Description;

	[FieldOffset(104)]
	[ReferenceTable("SkillGems")]
	public TRef StartSkillGem;

	[FieldOffset(120)]
	public TRef Unk018;

	[FieldOffset(136)]
	public int Unk019;

	[FieldOffset(140)]
	public int Unk020;

	[FieldOffset(144)]
	public int CharacterSize;

	[FieldOffset(148)]
	public TString IntroSoundFile;

	[FieldOffset(156)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TRef))]
	public TArray StartWeapons;

	[FieldOffset(172)]
	public TString Gender;

	[FieldOffset(180)]
	public TString TraitDescription;

	[FieldOffset(188)]
	public TRef Unk026;

	[FieldOffset(204)]
	public TRef Unk027;

	[FieldOffset(220)]
	public TRef Unk028;

	[FieldOffset(236)]
	public TRef Unk029;

	[FieldOffset(252)]
	public int Unk030;

	[FieldOffset(256)]
	[ElementType(typeof(TRef))]
	public TArray Unk031;

	[FieldOffset(272)]
	public TString PassiveTreeImage;

	[FieldOffset(280)]
	public int Unk033;

	[FieldOffset(284)]
	public int Unk034;

	[FieldOffset(288)]
	public TString TencentVideo;

	[FieldOffset(296)]
	public TString AttrsAsId;

	[FieldOffset(304)]
	public TString LoginScreen;

	[FieldOffset(312)]
	public TString PlayerCritter;

	[FieldOffset(320)]
	public TString PlayerEffect;

	[FieldOffset(328)]
	public TString AfterImage;

	[FieldOffset(336)]
	[ReferenceTable("MonsterVarieties")]
	public TRef Mirage;

	[FieldOffset(352)]
	[ReferenceTable("MonsterVarieties")]
	public TRef CloneImmobile;

	[FieldOffset(368)]
	[ReferenceTable("MonsterVarieties")]
	public TRef ReplicateClone;

	[FieldOffset(384)]
	[ReferenceTable("MonsterVarieties")]
	public TRef LightningClone;

	[FieldOffset(400)]
	public float Unk045;

	[FieldOffset(404)]
	public float Unk046;

	[FieldOffset(408)]
	public TString SkillTreeBackground;

	[FieldOffset(416)]
	[ReferenceTable("MonsterVarieties")]
	public TRef Clone;

	[FieldOffset(432)]
	[ReferenceTable("MonsterVarieties")]
	public TRef Double;

	[FieldOffset(448)]
	[ReferenceTable("MonsterVarieties")]
	public TRef MirageWarrior;

	[FieldOffset(464)]
	[ReferenceTable("MonsterVarieties")]
	public TRef DoubleTwo;

	[FieldOffset(480)]
	[ReferenceTable("MonsterVarieties")]
	public TRef DarkExile;

	[FieldOffset(496)]
	public TString Attr;

	[FieldOffset(504)]
	public TString AttrLowercase;

	[FieldOffset(512)]
	public TString Script;

	[FieldOffset(520)]
	public TRef Unk056;

	[FieldOffset(536)]
	public int Unk057;

	[FieldOffset(540)]
	[ReferenceTable("MonsterVarieties")]
	public TRef Unk058;

	[FieldOffset(556)]
	[ReferenceTable("MonsterVarieties")]
	public TRef Unk059;

	[FieldOffset(572)]
	public int Unk060;

	[FieldOffset(576)]
	public float Unk061;

}
