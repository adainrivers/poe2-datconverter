namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MicrotransactionPortalVariations
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemTypesKey;

	[FieldOffset(16)]
	public int Id;

	[FieldOffset(20)]
	public StringReference AOFile;

	[FieldOffset(28)]
	public StringReference MapAOFile;

	[FieldOffset(36)]
	public float Unk004;

	[FieldOffset(40)]
	[ReferenceTable("MiscObjects")]
	public TableReference MiscObject;

	[FieldOffset(56)]
	public StringReference PortalEffect;

	[FieldOffset(64)]
	public float Unk007;

	[FieldOffset(68)]
	public StringReference Unk008;

	[FieldOffset(76)]
	public StringReference PortalEffectLarge;

	[FieldOffset(84)]
	public int Unk010;

	[FieldOffset(88)]
	public int Unk011;

	[FieldOffset(92)]
	public StringReference Script;

}
