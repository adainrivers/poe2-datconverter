namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct EssenceType
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int EssenceType_001;

	[FieldOffset(12)]
	public TBool IsCorruptedEssence;

	[FieldOffset(13)]
	[ReferenceTable("Words")]
	public TableReference WordsKey;

	[FieldOffset(29)]
	public TableReference Unk004;

}
