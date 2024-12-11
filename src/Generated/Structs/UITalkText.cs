using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct UITalkText
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("UITalkCategories")]
	[EnumName("UITalkCategories")]
	public TEnum UITalkCategoriesKey;

	[FieldOffset(12)]
	public TString OGGFile;

	[FieldOffset(20)]
	public TString Text;

	[FieldOffset(28)]
	public bool Unk004;

	[FieldOffset(29)]
	[ReferenceTable("NPCTextAudio")]
	public TRef NPCTextAudio;

}
