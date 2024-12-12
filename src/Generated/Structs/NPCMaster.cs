namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NPCMaster
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public TBool Unk001;

	[FieldOffset(9)]
	public TBool Unk002;

	[FieldOffset(10)]
	[ReferenceTable("Mods")]
	public TableReference Signature_ModsKey;

	[FieldOffset(26)]
	public TBool Unk004;

	[FieldOffset(27)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TableReference))]
	public ArrayReference SpawnWeight_TagsKeys;

	[FieldOffset(43)]
	[ElementType(typeof(int))]
	public ArrayReference SpawnWeight_Values;

	[FieldOffset(59)]
	public TableReference Unk007;

	[FieldOffset(75)]
	public int Unk008;

	[FieldOffset(79)]
	public StringReference AreaDescription;

	[FieldOffset(87)]
	public TableReference Unk010;

	[FieldOffset(103)]
	public int Unk011;

	[FieldOffset(107)]
	[ReferenceTable("Stats")]
	public TableReference Unk012;

	[FieldOffset(123)]
	public TBool HasAreaMissions;

	[FieldOffset(124)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk014;

	[FieldOffset(140)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk015;

	[FieldOffset(156)]
	public TableReference Unk016;

	[FieldOffset(172)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk017;

	[FieldOffset(188)]
	public TableReference Unk018;

}
