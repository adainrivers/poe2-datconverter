namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistDoors
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Unk001;

	[FieldOffset(16)]
	[ReferenceTable("HeistJobs")]
	public TableReference HeistJobsKey1;

	[FieldOffset(32)]
	[ReferenceTable("HeistJobs")]
	public TableReference HeistJobsKey2;

	[FieldOffset(48)]
	public StringReference Unk004;

	[FieldOffset(56)]
	[ElementType(typeof(StringReference))]
	public ArrayReference Unk005;

	[FieldOffset(72)]
	[ElementType(typeof(StringReference))]
	public ArrayReference Unk006;

	[FieldOffset(88)]
	public int Unk007;

	[FieldOffset(92)]
	[ReferenceTable("HeistAreas")]
	public TableReference HeistAreasKey;

}
