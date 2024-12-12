namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct UITalkText
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("UITalkCategories")]
	[EnumName("UITalkCategories")]
	public TEnum UITalkCategoriesKey;

	[FieldOffset(12)]
	public StringReference OGGFile;

	[FieldOffset(20)]
	public StringReference Text;

	[FieldOffset(28)]
	public TBool Unk004;

	[FieldOffset(29)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference NPCTextAudio;

}
