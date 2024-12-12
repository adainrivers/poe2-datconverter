namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Flasks
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemTypesKey;

	[FieldOffset(16)]
	public StringReference Name;

	[FieldOffset(24)]
	[ReferenceTable("FlaskType")]
	[EnumName("FlaskType")]
	public TEnum Type;

	[FieldOffset(28)]
	public int LifePerUse;

	[FieldOffset(32)]
	public int ManaPerUse;

	[FieldOffset(36)]
	public int RecoveryTime;

	[FieldOffset(40)]
	[ReferenceTable("BuffDefinitions")]
	public TableReference BuffDefinitionsKey;

	[FieldOffset(56)]
	[ElementType(typeof(int))]
	public ArrayReference BuffStatValues;

	[FieldOffset(72)]
	public int RecoveryTime2;

	[FieldOffset(76)]
	[ElementType(typeof(int))]
	public ArrayReference BuffStatValues2;

}
