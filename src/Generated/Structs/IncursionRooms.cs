namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct IncursionRooms
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Name;

	[FieldOffset(16)]
	public int Tier;

	[FieldOffset(20)]
	public int MinLevel;

	[FieldOffset(24)]
	[ReferenceTable("IncursionRooms")]
	public TableReference RoomUpgrade_IncursionRoomsKey;

	[FieldOffset(32)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Mods;

	[FieldOffset(48)]
	public StringReference PresentARMFile;

	[FieldOffset(56)]
	public int HASH16;

	[FieldOffset(60)]
	[ReferenceTable("IncursionArchitect")]
	public TableReference IncursionArchitectKey;

	[FieldOffset(76)]
	public StringReference PastARMFile;

	[FieldOffset(84)]
	public StringReference TSIFile;

	[FieldOffset(92)]
	public StringReference UIIcon;

	[FieldOffset(100)]
	public StringReference FlavourText;

	[FieldOffset(108)]
	public StringReference Description;

	[FieldOffset(116)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference AchievementItemsKeys;

	[FieldOffset(132)]
	public int Unk015;

	[FieldOffset(136)]
	public int Unk016;

	[FieldOffset(140)]
	[ReferenceTable("IncursionRooms")]
	public TableReference RoomUpgradeFrom_IncursionRoomsKey;

	[FieldOffset(148)]
	[ReferenceTable("FlavourText")]
	public TableReference ItemisedFlavourText;

	[FieldOffset(164)]
	public StringReference Unk019;

	[FieldOffset(172)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk020;

}
