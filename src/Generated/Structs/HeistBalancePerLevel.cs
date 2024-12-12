namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistBalancePerLevel
{
	[FieldOffset(0)]
	public int Level;

	[FieldOffset(4)]
	public float Unk001;

	[FieldOffset(8)]
	public float Unk002;

	[FieldOffset(12)]
	public int Unk003;

	[FieldOffset(16)]
	public int Unk004;

	[FieldOffset(20)]
	public float Unk005;

	[FieldOffset(24)]
	public float Unk006;

	[FieldOffset(28)]
	[ReferenceTable("HeistValueScaling")]
	public TableReference HeistValueScalingKey1;

	[FieldOffset(44)]
	[ReferenceTable("HeistValueScaling")]
	public TableReference HeistValueScalingKey2;

	[FieldOffset(60)]
	[ReferenceTable("HeistValueScaling")]
	public TableReference HeistValueScalingKey3;

	[FieldOffset(76)]
	[ReferenceTable("HeistValueScaling")]
	public TableReference HeistValueScalingKey4;

	[FieldOffset(92)]
	[ReferenceTable("HeistValueScaling")]
	public TableReference HeistValueScalingKey5;

	[FieldOffset(108)]
	public float Unk012;

	[FieldOffset(112)]
	public float Unk013;

	[FieldOffset(116)]
	public float Unk014;

	[FieldOffset(120)]
	public float Unk015;

	[FieldOffset(124)]
	[ReferenceTable("HeistValueScaling")]
	public TableReference HeistValueScalingKey6;

	[FieldOffset(140)]
	[ReferenceTable("HeistValueScaling")]
	public TableReference HeistValueScalingKey7;

	[FieldOffset(156)]
	public float Unk018;

	[FieldOffset(160)]
	public float Unk019;

	[FieldOffset(164)]
	public int Unk020;

}
