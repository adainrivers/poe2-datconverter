namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Realms
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Name;

	[FieldOffset(16)]
	[ElementType(typeof(StringReference))]
	public ArrayReference Server;

	[FieldOffset(32)]
	public TBool IsEnabled;

	[FieldOffset(33)]
	[ElementType(typeof(StringReference))]
	public ArrayReference Server2;

	[FieldOffset(49)]
	public StringReference ShortName;

	[FieldOffset(57)]
	[ReferenceTable("Realms")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk006;

	[FieldOffset(73)]
	[ReferenceTable("Realms")]
	public TableReference Unk007;

	[FieldOffset(81)]
	public int Unk008;

	[FieldOffset(85)]
	public TBool IsGammaRealm;

	[FieldOffset(86)]
	[ElementType(typeof(StringReference))]
	public ArrayReference SpeedtestUrl;

}
