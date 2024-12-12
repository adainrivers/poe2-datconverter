namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ExplodingStormBuffs
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("BuffDefinitions")]
	public TableReference BuffDefinitionsKey1;

	[FieldOffset(24)]
	public TableReference Unk002;

	[FieldOffset(40)]
	[ElementType(typeof(int))]
	public ArrayReference StatValues;

	[FieldOffset(56)]
	public int Unk004;

	[FieldOffset(60)]
	[ElementType(typeof(int))]
	public ArrayReference Unk005;

	[FieldOffset(76)]
	public int Unk006;

	[FieldOffset(80)]
	public int Unk007;

	[FieldOffset(84)]
	public int Unk008;

	[FieldOffset(88)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference Friendly_MonsterVarietiesKey;

	[FieldOffset(104)]
	[ReferenceTable("MiscObjects")]
	public TableReference MiscObjectsKey;

	[FieldOffset(120)]
	[ReferenceTable("MiscAnimated")]
	public TableReference MiscAnimatedKey;

	[FieldOffset(136)]
	[ReferenceTable("BuffVisuals")]
	public TableReference BuffVisualsKey;

	[FieldOffset(152)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference Enemy_MonsterVarietiesKey;

	[FieldOffset(168)]
	public int Unk014;

	[FieldOffset(172)]
	public int Unk015;

	[FieldOffset(176)]
	public int Unk016;

	[FieldOffset(180)]
	[ReferenceTable("BuffDefinitions")]
	public TableReference BuffDefinitionsKey2;

	[FieldOffset(196)]
	public TBool IsOnlySpawningNearPlayer;

}
