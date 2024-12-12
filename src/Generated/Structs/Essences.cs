namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Essences
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemTypesKey;

	[FieldOffset(16)]
	public TableReference Unk001;

	[FieldOffset(32)]
	public TableReference Unk002;

	[FieldOffset(48)]
	public TableReference Unk003;

	[FieldOffset(64)]
	public TableReference Unk004;

	[FieldOffset(80)]
	public TableReference Unk005;

	[FieldOffset(96)]
	public TableReference Unk006;

	[FieldOffset(112)]
	public TableReference Unk007;

	[FieldOffset(128)]
	public TableReference Unk008;

	[FieldOffset(144)]
	public TableReference Unk009;

	[FieldOffset(160)]
	public TableReference Unk010;

	[FieldOffset(176)]
	public TableReference Unk011;

	[FieldOffset(192)]
	[ReferenceTable("Mods")]
	public TableReference Display_Wand_ModsKey;

	[FieldOffset(208)]
	[ReferenceTable("Mods")]
	public TableReference Display_Bow_ModsKey;

	[FieldOffset(224)]
	[ReferenceTable("Mods")]
	public TableReference Display_Quiver_ModsKey;

	[FieldOffset(240)]
	[ReferenceTable("Mods")]
	public TableReference Display_Amulet_ModsKey;

	[FieldOffset(256)]
	[ReferenceTable("Mods")]
	public TableReference Display_Ring_ModsKey;

	[FieldOffset(272)]
	[ReferenceTable("Mods")]
	public TableReference Display_Belt_ModsKey;

	[FieldOffset(288)]
	[ReferenceTable("Mods")]
	public TableReference Display_Gloves_ModsKey;

	[FieldOffset(304)]
	[ReferenceTable("Mods")]
	public TableReference Display_Boots_ModsKey;

	[FieldOffset(320)]
	[ReferenceTable("Mods")]
	public TableReference Display_BodyArmour_ModsKey;

	[FieldOffset(336)]
	[ReferenceTable("Mods")]
	public TableReference Display_Helmet_ModsKey;

	[FieldOffset(352)]
	[ReferenceTable("Mods")]
	public TableReference Display_Shield_ModsKey;

	[FieldOffset(368)]
	public int HASH32;

	[FieldOffset(372)]
	[ElementType(typeof(int))]
	public ArrayReference DropLevel;

	[FieldOffset(388)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Monster_ModsKeys;

	[FieldOffset(404)]
	[ReferenceTable("EssenceType")]
	public TableReference EssenceTypeKey;

	[FieldOffset(420)]
	public int Level;

	[FieldOffset(424)]
	[ElementType(typeof(int))]
	public ArrayReference Unk028;

	[FieldOffset(440)]
	[ReferenceTable("Mods")]
	public TableReference Display_Weapon_ModsKey;

	[FieldOffset(456)]
	[ReferenceTable("Mods")]
	public TableReference Display_MeleeWeapon_ModsKey;

	[FieldOffset(472)]
	[ReferenceTable("Mods")]
	public TableReference Display_OneHandWeapon_ModsKey;

	[FieldOffset(488)]
	[ReferenceTable("Mods")]
	public TableReference Display_TwoHandWeapon_ModsKey;

	[FieldOffset(504)]
	[ReferenceTable("Mods")]
	public TableReference Display_TwoHandMeleeWeapon_ModsKey;

	[FieldOffset(520)]
	[ReferenceTable("Mods")]
	public TableReference Display_Armour_ModsKey;

	[FieldOffset(536)]
	[ReferenceTable("Mods")]
	public TableReference Display_RangedWeapon_ModsKey;

	[FieldOffset(552)]
	[ReferenceTable("Mods")]
	public TableReference Helmet_ModsKey;

	[FieldOffset(568)]
	[ReferenceTable("Mods")]
	public TableReference BodyArmour_ModsKey;

	[FieldOffset(584)]
	[ReferenceTable("Mods")]
	public TableReference Boots_ModsKey;

	[FieldOffset(600)]
	[ReferenceTable("Mods")]
	public TableReference Gloves_ModsKey;

	[FieldOffset(616)]
	[ReferenceTable("Mods")]
	public TableReference Bow_ModsKey;

	[FieldOffset(632)]
	[ReferenceTable("Mods")]
	public TableReference Wand_ModsKey;

	[FieldOffset(648)]
	[ReferenceTable("Mods")]
	public TableReference Staff_ModsKey;

	[FieldOffset(664)]
	[ReferenceTable("Mods")]
	public TableReference TwoHandSword_ModsKey;

	[FieldOffset(680)]
	[ReferenceTable("Mods")]
	public TableReference TwoHandAxe_ModsKey;

	[FieldOffset(696)]
	[ReferenceTable("Mods")]
	public TableReference TwoHandMace_ModsKey;

	[FieldOffset(712)]
	[ReferenceTable("Mods")]
	public TableReference Claw_ModsKey;

	[FieldOffset(728)]
	[ReferenceTable("Mods")]
	public TableReference Dagger_ModsKey;

	[FieldOffset(744)]
	[ReferenceTable("Mods")]
	public TableReference OneHandSword_ModsKey;

	[FieldOffset(760)]
	[ReferenceTable("Mods")]
	public TableReference OneHandThrustingSword_ModsKey;

	[FieldOffset(776)]
	[ReferenceTable("Mods")]
	public TableReference OneHandAxe_ModsKey;

	[FieldOffset(792)]
	[ReferenceTable("Mods")]
	public TableReference OneHandMace_ModsKey;

	[FieldOffset(808)]
	[ReferenceTable("Mods")]
	public TableReference Sceptre_ModsKey;

	[FieldOffset(824)]
	[ReferenceTable("Mods")]
	public TableReference Display_Monster_ModsKey;

	[FieldOffset(840)]
	public int ItemLevelRestriction;

	[FieldOffset(844)]
	[ReferenceTable("Mods")]
	public TableReference Belt_ModsKey;

	[FieldOffset(860)]
	[ReferenceTable("Mods")]
	public TableReference Amulet_ModsKey;

	[FieldOffset(876)]
	[ReferenceTable("Mods")]
	public TableReference Ring_ModsKey;

	[FieldOffset(892)]
	[ReferenceTable("Mods")]
	public TableReference Display_Jewellery_ModsKey;

	[FieldOffset(908)]
	[ReferenceTable("Mods")]
	public TableReference Shield_ModsKey;

	[FieldOffset(924)]
	[ReferenceTable("Mods")]
	public TableReference Display_Items_ModsKey;

	[FieldOffset(940)]
	public TBool IsScreamingEssence;

	[FieldOffset(941)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference MemoryLines;

	[FieldOffset(957)]
	[ElementType(typeof(int))]
	public ArrayReference Unk063;

	[FieldOffset(973)]
	[ElementType(typeof(int))]
	public ArrayReference Level2;

}
