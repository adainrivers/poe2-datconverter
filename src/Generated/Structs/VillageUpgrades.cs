namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct VillageUpgrades
{
	[FieldOffset(0)]
	public TableReference Unk000;

	[FieldOffset(16)]
	public int Tier;

	[FieldOffset(20)]
	public StringReference Text;

	[FieldOffset(28)]
	public int Unk003;

	[FieldOffset(32)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk004;

	[FieldOffset(48)]
	[ElementType(typeof(int))]
	public ArrayReference Unk005;

	[FieldOffset(64)]
	public int Unk006;

	[FieldOffset(68)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference RuneItem;

	[FieldOffset(84)]
	[ElementType(typeof(int))]
	public ArrayReference Unk008;

	[FieldOffset(100)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Stats;

	[FieldOffset(116)]
	[ElementType(typeof(int))]
	public ArrayReference StatsValues;

	[FieldOffset(132)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference UpgradeTextAudio;

}
