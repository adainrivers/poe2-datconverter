using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CraftingBenchOptions
{
	[FieldOffset(0)]
	[ReferenceTable("HideoutNPCs")]
	public TRef HideoutNPCsKey;

	[FieldOffset(16)]
	public int Order;

	[FieldOffset(20)]
	[ReferenceTable("Mods")]
	public TRef AddMod;

	[FieldOffset(36)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TRef))]
	public TArray Cost_BaseItemTypes;

	[FieldOffset(52)]
	[ElementType(typeof(int))]
	public TArray Cost_Values;

	[FieldOffset(68)]
	public int RequiredLevel;

	[FieldOffset(72)]
	public TString Name;

	[FieldOffset(80)]
	[ReferenceTable("CraftingBenchCustomActions")]
	[EnumName("CraftingBenchCustomActions")]
	public TEnum CraftingBenchCustomAction;

	[FieldOffset(84)]
	[ReferenceTable("ItemClasses")]
	[ElementType(typeof(TRef))]
	public TArray ItemClasses;

	[FieldOffset(100)]
	public int Links;

	[FieldOffset(104)]
	public TString SocketColours;

	[FieldOffset(112)]
	public int Sockets;

	[FieldOffset(116)]
	public int ItemQuantity;

	[FieldOffset(120)]
	[ElementType(typeof(int))]
	public TArray Unk013;

	[FieldOffset(136)]
	public TString Description;

	[FieldOffset(144)]
	public bool IsDisabled;

	[FieldOffset(145)]
	public bool IsAreaOption;

	[FieldOffset(146)]
	[ReferenceTable("RecipeUnlockDisplay")]
	[ElementType(typeof(int))]
	public TArray RecipeIds;

	[FieldOffset(162)]
	public int Tier;

	[FieldOffset(166)]
	[ReferenceTable("CraftingItemClassCategories")]
	[ElementType(typeof(TRef))]
	public TArray CraftingItemClassCategories;

	[FieldOffset(182)]
	public int Unk020;

	[FieldOffset(186)]
	[ReferenceTable("CraftingBenchUnlockCategories")]
	public TRef UnlockCategory;

	[FieldOffset(202)]
	public int UnveilsRequired;

	[FieldOffset(206)]
	public int UnveilsRequired2;

	[FieldOffset(210)]
	[ElementType(typeof(TRef))]
	public TArray Unk024;

	[FieldOffset(226)]
	[ElementType(typeof(TRef))]
	public TArray Unk025;

	[FieldOffset(242)]
	public int Unk026;

	[FieldOffset(246)]
	public int Unk027;

	[FieldOffset(250)]
	public TRef Unk028;

	[FieldOffset(266)]
	[ReferenceTable("Mods")]
	public TRef AddEnchantment;

	[FieldOffset(282)]
	[ReferenceTable("CraftingBenchSortCategories")]
	public TRef SortCategory;

	[FieldOffset(298)]
	public TRef Unk031;

	[FieldOffset(314)]
	public bool Unk032;

	[FieldOffset(315)]
	public int Unk033;

	[FieldOffset(319)]
	[ReferenceTable("Stats")]
	public TRef Unk034;

	[FieldOffset(335)]
	[ReferenceTable("Stats")]
	public TRef Unk035;

	[FieldOffset(351)]
	[ReferenceTable("Stats")]
	public TRef Unk036;

	[FieldOffset(367)]
	public bool MapDevice;

	[FieldOffset(368)]
	[ElementType(typeof(TRef))]
	public TArray Unk038;

	[FieldOffset(384)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TRef))]
	public TArray Tags;

}
