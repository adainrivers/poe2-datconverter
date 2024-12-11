using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Essences
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItemTypesKey;

	[FieldOffset(16)]
	public TRef Unk001;

	[FieldOffset(32)]
	public TRef Unk002;

	[FieldOffset(48)]
	public TRef Unk003;

	[FieldOffset(64)]
	public TRef Unk004;

	[FieldOffset(80)]
	public TRef Unk005;

	[FieldOffset(96)]
	public TRef Unk006;

	[FieldOffset(112)]
	public TRef Unk007;

	[FieldOffset(128)]
	public TRef Unk008;

	[FieldOffset(144)]
	public TRef Unk009;

	[FieldOffset(160)]
	public TRef Unk010;

	[FieldOffset(176)]
	public TRef Unk011;

	[FieldOffset(192)]
	[ReferenceTable("Mods")]
	public TRef Display_Wand_ModsKey;

	[FieldOffset(208)]
	[ReferenceTable("Mods")]
	public TRef Display_Bow_ModsKey;

	[FieldOffset(224)]
	[ReferenceTable("Mods")]
	public TRef Display_Quiver_ModsKey;

	[FieldOffset(240)]
	[ReferenceTable("Mods")]
	public TRef Display_Amulet_ModsKey;

	[FieldOffset(256)]
	[ReferenceTable("Mods")]
	public TRef Display_Ring_ModsKey;

	[FieldOffset(272)]
	[ReferenceTable("Mods")]
	public TRef Display_Belt_ModsKey;

	[FieldOffset(288)]
	[ReferenceTable("Mods")]
	public TRef Display_Gloves_ModsKey;

	[FieldOffset(304)]
	[ReferenceTable("Mods")]
	public TRef Display_Boots_ModsKey;

	[FieldOffset(320)]
	[ReferenceTable("Mods")]
	public TRef Display_BodyArmour_ModsKey;

	[FieldOffset(336)]
	[ReferenceTable("Mods")]
	public TRef Display_Helmet_ModsKey;

	[FieldOffset(352)]
	[ReferenceTable("Mods")]
	public TRef Display_Shield_ModsKey;

	[FieldOffset(368)]
	public int HASH32;

	[FieldOffset(372)]
	[ElementType(typeof(int))]
	public TArray DropLevel;

	[FieldOffset(388)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TRef))]
	public TArray Monster_ModsKeys;

	[FieldOffset(404)]
	[ReferenceTable("EssenceType")]
	public TRef EssenceTypeKey;

	[FieldOffset(420)]
	public int Level;

	[FieldOffset(424)]
	[ElementType(typeof(int))]
	public TArray Unk028;

	[FieldOffset(440)]
	[ReferenceTable("Mods")]
	public TRef Display_Weapon_ModsKey;

	[FieldOffset(456)]
	[ReferenceTable("Mods")]
	public TRef Display_MeleeWeapon_ModsKey;

	[FieldOffset(472)]
	[ReferenceTable("Mods")]
	public TRef Display_OneHandWeapon_ModsKey;

	[FieldOffset(488)]
	[ReferenceTable("Mods")]
	public TRef Display_TwoHandWeapon_ModsKey;

	[FieldOffset(504)]
	[ReferenceTable("Mods")]
	public TRef Display_TwoHandMeleeWeapon_ModsKey;

	[FieldOffset(520)]
	[ReferenceTable("Mods")]
	public TRef Display_Armour_ModsKey;

	[FieldOffset(536)]
	[ReferenceTable("Mods")]
	public TRef Display_RangedWeapon_ModsKey;

	[FieldOffset(552)]
	[ReferenceTable("Mods")]
	public TRef Helmet_ModsKey;

	[FieldOffset(568)]
	[ReferenceTable("Mods")]
	public TRef BodyArmour_ModsKey;

	[FieldOffset(584)]
	[ReferenceTable("Mods")]
	public TRef Boots_ModsKey;

	[FieldOffset(600)]
	[ReferenceTable("Mods")]
	public TRef Gloves_ModsKey;

	[FieldOffset(616)]
	[ReferenceTable("Mods")]
	public TRef Bow_ModsKey;

	[FieldOffset(632)]
	[ReferenceTable("Mods")]
	public TRef Wand_ModsKey;

	[FieldOffset(648)]
	[ReferenceTable("Mods")]
	public TRef Staff_ModsKey;

	[FieldOffset(664)]
	[ReferenceTable("Mods")]
	public TRef TwoHandSword_ModsKey;

	[FieldOffset(680)]
	[ReferenceTable("Mods")]
	public TRef TwoHandAxe_ModsKey;

	[FieldOffset(696)]
	[ReferenceTable("Mods")]
	public TRef TwoHandMace_ModsKey;

	[FieldOffset(712)]
	[ReferenceTable("Mods")]
	public TRef Claw_ModsKey;

	[FieldOffset(728)]
	[ReferenceTable("Mods")]
	public TRef Dagger_ModsKey;

	[FieldOffset(744)]
	[ReferenceTable("Mods")]
	public TRef OneHandSword_ModsKey;

	[FieldOffset(760)]
	[ReferenceTable("Mods")]
	public TRef OneHandThrustingSword_ModsKey;

	[FieldOffset(776)]
	[ReferenceTable("Mods")]
	public TRef OneHandAxe_ModsKey;

	[FieldOffset(792)]
	[ReferenceTable("Mods")]
	public TRef OneHandMace_ModsKey;

	[FieldOffset(808)]
	[ReferenceTable("Mods")]
	public TRef Sceptre_ModsKey;

	[FieldOffset(824)]
	[ReferenceTable("Mods")]
	public TRef Display_Monster_ModsKey;

	[FieldOffset(840)]
	public int ItemLevelRestriction;

	[FieldOffset(844)]
	[ReferenceTable("Mods")]
	public TRef Belt_ModsKey;

	[FieldOffset(860)]
	[ReferenceTable("Mods")]
	public TRef Amulet_ModsKey;

	[FieldOffset(876)]
	[ReferenceTable("Mods")]
	public TRef Ring_ModsKey;

	[FieldOffset(892)]
	[ReferenceTable("Mods")]
	public TRef Display_Jewellery_ModsKey;

	[FieldOffset(908)]
	[ReferenceTable("Mods")]
	public TRef Shield_ModsKey;

	[FieldOffset(924)]
	[ReferenceTable("Mods")]
	public TRef Display_Items_ModsKey;

	[FieldOffset(940)]
	public bool IsScreamingEssence;

	[FieldOffset(941)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TRef))]
	public TArray MemoryLines;

	[FieldOffset(957)]
	[ElementType(typeof(int))]
	public TArray Unk063;

	[FieldOffset(973)]
	[ElementType(typeof(int))]
	public TArray Level2;

}
