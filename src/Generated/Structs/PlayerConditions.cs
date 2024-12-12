namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PlayerConditions
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("BuffDefinitions")]
	[ElementType(typeof(TableReference))]
	public ArrayReference BuffDefinitionsKeys;

	[FieldOffset(24)]
	public TBool Unk002;

	[FieldOffset(25)]
	public int BuffStacks;

	[FieldOffset(29)]
	[ReferenceTable("Characters")]
	public TableReference CharactersKey;

	[FieldOffset(45)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference StatsKeys;

	[FieldOffset(61)]
	public TBool Unk006;

	[FieldOffset(62)]
	public int StatValue;

	[FieldOffset(66)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk008;

	[FieldOffset(82)]
	public TBool Unk009;

}
