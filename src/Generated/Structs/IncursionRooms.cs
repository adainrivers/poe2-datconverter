using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct IncursionRooms
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Name;

	[FieldOffset(16)]
	public int Tier;

	[FieldOffset(20)]
	public int MinLevel;

	[FieldOffset(24)]
	[ReferenceTable("IncursionRooms")]
	public TRef RoomUpgrade_IncursionRoomsKey;

	[FieldOffset(32)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TRef))]
	public TArray Mods;

	[FieldOffset(48)]
	public TString PresentARMFile;

	[FieldOffset(56)]
	public int HASH16;

	[FieldOffset(60)]
	[ReferenceTable("IncursionArchitect")]
	public TRef IncursionArchitectKey;

	[FieldOffset(76)]
	public TString PastARMFile;

	[FieldOffset(84)]
	public TString TSIFile;

	[FieldOffset(92)]
	public TString UIIcon;

	[FieldOffset(100)]
	public TString FlavourText;

	[FieldOffset(108)]
	public TString Description;

	[FieldOffset(116)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray AchievementItemsKeys;

	[FieldOffset(132)]
	public int Unk015;

	[FieldOffset(136)]
	public int Unk016;

	[FieldOffset(140)]
	[ReferenceTable("IncursionRooms")]
	public TRef RoomUpgradeFrom_IncursionRoomsKey;

	[FieldOffset(148)]
	[ReferenceTable("FlavourText")]
	public TRef ItemisedFlavourText;

	[FieldOffset(164)]
	public TString Unk019;

	[FieldOffset(172)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TRef))]
	public TArray Unk020;

}
