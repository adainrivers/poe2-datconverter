namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistRooms
{
	[FieldOffset(0)]
	[ReferenceTable("HeistAreas")]
	public TableReference HeistAreasKey;

	[FieldOffset(16)]
	public int Id;

	[FieldOffset(20)]
	public StringReference ARMFile;

	[FieldOffset(28)]
	[ReferenceTable("HeistJobs")]
	public TableReference HeistJobsKey1;

	[FieldOffset(44)]
	[ReferenceTable("HeistJobs")]
	public TableReference HeistJobsKey2;

	[FieldOffset(60)]
	public int Unk005;

	[FieldOffset(64)]
	public int Unk006;

	[FieldOffset(68)]
	public int Unk007;

	[FieldOffset(72)]
	public StringReference Unk008;

	[FieldOffset(80)]
	public float Unk009;

	[FieldOffset(84)]
	public TBool Unk010;

	[FieldOffset(85)]
	public TBool Unk011;

}
