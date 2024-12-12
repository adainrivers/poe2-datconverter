namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BuffDefinitions
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Description;

	[FieldOffset(16)]
	public TBool Invisible;

	[FieldOffset(17)]
	public TBool Removable;

	[FieldOffset(18)]
	public StringReference Name;

	[FieldOffset(26)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference StatsKeys;

	[FieldOffset(42)]
	public TBool Unk006;

	[FieldOffset(43)]
	public int Unk007;

	[FieldOffset(47)]
	public TBool Unk008;

	[FieldOffset(48)]
	[ReferenceTable("Stats")]
	public TableReference Maximum_StatsKey;

	[FieldOffset(64)]
	[ReferenceTable("Stats")]
	public TableReference Current_StatsKey;

	[FieldOffset(80)]
	public TBool Unk011;

	[FieldOffset(81)]
	public int Unk012;

	[FieldOffset(85)]
	[ReferenceTable("BuffVisuals")]
	public TableReference BuffVisualsKey;

	[FieldOffset(101)]
	public TBool Unk014;

	[FieldOffset(102)]
	public TBool Unk015;

	[FieldOffset(103)]
	public int BuffCategory;

	[FieldOffset(107)]
	public TBool Unk017;

	[FieldOffset(108)]
	public TBool Unk018;

	[FieldOffset(109)]
	public TBool Unk019;

	[FieldOffset(110)]
	public TBool Unk020;

	[FieldOffset(111)]
	public int BuffLimit;

	[FieldOffset(115)]
	public TBool Unk022;

	[FieldOffset(116)]
	public StringReference Id2;

	[FieldOffset(124)]
	public TBool IsRecovery;

	[FieldOffset(125)]
	public TBool Unk025;

	[FieldOffset(126)]
	public TableReference Unk026;

	[FieldOffset(142)]
	public TBool Unk027;

	[FieldOffset(143)]
	public int Unk028;

	[FieldOffset(147)]
	public TBool Unk029;

	[FieldOffset(148)]
	public TBool Unk030;

	[FieldOffset(149)]
	public int Unk031;

	[FieldOffset(153)]
	[ElementType(typeof(int))]
	public ArrayReference Unk032;

	[FieldOffset(169)]
	public TBool Unk033;

	[FieldOffset(170)]
	public TBool Unk034;

	[FieldOffset(171)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk035;

	[FieldOffset(187)]
	public TBool Unk036;

	[FieldOffset(188)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk037;

	[FieldOffset(204)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference BinaryStats;

	[FieldOffset(220)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk039;

	[FieldOffset(236)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk040;

	[FieldOffset(252)]
	public TBool Unk041;

	[FieldOffset(253)]
	public TBool Unk042;

	[FieldOffset(254)]
	public TBool Unk043;

	[FieldOffset(255)]
	public TBool Unk044;

	[FieldOffset(256)]
	public TBool Unk045;

	[FieldOffset(257)]
	[ReferenceTable("Stats")]
	public TableReference Unk046;

	[FieldOffset(273)]
	[ElementType(typeof(int))]
	public ArrayReference Unk047;

	[FieldOffset(289)]
	public StringReference Unk048;

	[FieldOffset(297)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk049;

	[FieldOffset(313)]
	public TBool Unk050;

}
