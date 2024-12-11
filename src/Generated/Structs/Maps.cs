using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Maps
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItemTypesKey;

	[FieldOffset(16)]
	[ReferenceTable("WorldAreas")]
	public TRef Regular_WorldAreasKey;

	[FieldOffset(32)]
	[ReferenceTable("WorldAreas")]
	public TRef Unique_WorldAreasKey;

	[FieldOffset(48)]
	[ReferenceTable("BaseItemTypes")]
	public TRef MapUpgrade_BaseItemTypesKey;

	[FieldOffset(64)]
	[ReferenceTable("MonsterPacks")]
	[ElementType(typeof(TRef))]
	public TArray MonsterPacksKeys;

	[FieldOffset(80)]
	[ReferenceTable("AchievementItems")]
	public TRef AchievementItem;

	[FieldOffset(96)]
	public TString Regular_GuildCharacter;

	[FieldOffset(104)]
	public TString Unique_GuildCharacter;

	[FieldOffset(112)]
	public int Tier;

	[FieldOffset(116)]
	[ReferenceTable("Maps")]
	public TRef Shaped_Base_MapsKey;

	[FieldOffset(124)]
	public int Shaped_AreaLevel;

	[FieldOffset(128)]
	[ReferenceTable("Maps")]
	public TRef UpgradedFrom_MapsKey;

	[FieldOffset(136)]
	[ReferenceTable("Maps")]
	public TRef MapsKey2;

	[FieldOffset(144)]
	[ReferenceTable("Maps")]
	public TRef MapsKey3;

	[FieldOffset(152)]
	public int MapSeriesKey;

	[FieldOffset(156)]
	public bool Unk015;

	[FieldOffset(157)]
	public bool Unk016;

	[FieldOffset(158)]
	public bool Unk017;

}
