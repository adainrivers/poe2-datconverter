namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CraftingBenchOptions
{
	[FieldOffset(0)]
	[ReferenceTable("HideoutNPCs")]
	public TableReference HideoutNPCsKey;

	[FieldOffset(16)]
	public int Order;

	[FieldOffset(20)]
	[ReferenceTable("Mods")]
	public TableReference AddMod;

	[FieldOffset(36)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Cost_BaseItemTypes;

	[FieldOffset(52)]
	[ElementType(typeof(int))]
	public ArrayReference Cost_Values;

	[FieldOffset(68)]
	public int RequiredLevel;

	[FieldOffset(72)]
	public StringReference Name;

	[FieldOffset(80)]
	[ReferenceTable("CraftingBenchCustomActions")]
	[EnumName("CraftingBenchCustomActions")]
	public TEnum CraftingBenchCustomAction;

	[FieldOffset(84)]
	[ReferenceTable("ItemClasses")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ItemClasses;

	[FieldOffset(100)]
	public int Links;

	[FieldOffset(104)]
	public StringReference SocketColours;

	[FieldOffset(112)]
	public int Sockets;

	[FieldOffset(116)]
	public int ItemQuantity;

	[FieldOffset(120)]
	[ElementType(typeof(int))]
	public ArrayReference Unk013;

	[FieldOffset(136)]
	public StringReference Description;

	[FieldOffset(144)]
	public TBool IsDisabled;

	[FieldOffset(145)]
	public TBool IsAreaOption;

	[FieldOffset(146)]
	[ReferenceTable("RecipeUnlockDisplay")]
	[ElementType(typeof(int))]
	public ArrayReference RecipeIds;

	[FieldOffset(162)]
	public int Tier;

	[FieldOffset(166)]
	[ReferenceTable("CraftingItemClassCategories")]
	[ElementType(typeof(TableReference))]
	public ArrayReference CraftingItemClassCategories;

	[FieldOffset(182)]
	public int Unk020;

	[FieldOffset(186)]
	[ReferenceTable("CraftingBenchUnlockCategories")]
	public TableReference UnlockCategory;

	[FieldOffset(202)]
	public int UnveilsRequired;

	[FieldOffset(206)]
	public int UnveilsRequired2;

	[FieldOffset(210)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk024;

	[FieldOffset(226)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk025;

	[FieldOffset(242)]
	public int Unk026;

	[FieldOffset(246)]
	public int Unk027;

	[FieldOffset(250)]
	public TableReference Unk028;

	[FieldOffset(266)]
	[ReferenceTable("Mods")]
	public TableReference AddEnchantment;

	[FieldOffset(282)]
	[ReferenceTable("CraftingBenchSortCategories")]
	public TableReference SortCategory;

	[FieldOffset(298)]
	public TableReference Unk031;

	[FieldOffset(314)]
	public TBool Unk032;

	[FieldOffset(315)]
	public int Unk033;

	[FieldOffset(319)]
	[ReferenceTable("Stats")]
	public TableReference Unk034;

	[FieldOffset(335)]
	[ReferenceTable("Stats")]
	public TableReference Unk035;

	[FieldOffset(351)]
	[ReferenceTable("Stats")]
	public TableReference Unk036;

	[FieldOffset(367)]
	public TBool MapDevice;

	[FieldOffset(368)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk038;

	[FieldOffset(384)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Tags;

}
