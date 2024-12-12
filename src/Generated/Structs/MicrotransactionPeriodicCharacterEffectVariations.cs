namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MicrotransactionPeriodicCharacterEffectVariations
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference AOFile;

	[FieldOffset(16)]
	[ReferenceTable("MiscObjects")]
	public TableReference MiscObject;

	[FieldOffset(32)]
	public int Unk003;

}
