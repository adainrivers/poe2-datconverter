namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LakeRooms
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ElementType(typeof(StringReference))]
	public ArrayReference ARMFiles;

	[FieldOffset(24)]
	public StringReference Script;

	[FieldOffset(32)]
	[ElementType(typeof(int))]
	public ArrayReference Unk003;

	[FieldOffset(48)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Stats;

	[FieldOffset(64)]
	[ElementType(typeof(int))]
	public ArrayReference StatsValues;

	[FieldOffset(80)]
	public StringReference Description;

	[FieldOffset(88)]
	public StringReference Name;

	[FieldOffset(96)]
	public int Type;

	[FieldOffset(100)]
	[ReferenceTable("WorldAreas")]
	public TableReference WorldArea;

	[FieldOffset(116)]
	public StringReference Icon;

	[FieldOffset(124)]
	public int Unk011;

	[FieldOffset(128)]
	public int MinLevel;

	[FieldOffset(132)]
	public TableReference Unk013;

	[FieldOffset(148)]
	public TBool Unk014;

	[FieldOffset(149)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ExtraStats;

	[FieldOffset(165)]
	[ElementType(typeof(int))]
	public ArrayReference ExtraStatsValues;

	[FieldOffset(181)]
	public StringReference ReminderText;

	[FieldOffset(189)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference TextAudio;

	[FieldOffset(205)]
	public TableReference Unk019;

	[FieldOffset(221)]
	public TBool Unk020;

}
