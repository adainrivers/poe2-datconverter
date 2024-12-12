namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BetrayalChoiceActions
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("BetrayalChoices")]
	public TableReference BetrayalChoicesKey;

	[FieldOffset(24)]
	[ReferenceTable("ClientStrings")]
	public TableReference ClientStringsKey;

}
