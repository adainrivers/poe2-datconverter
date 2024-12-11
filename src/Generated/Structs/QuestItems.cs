using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct QuestItems
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef Item;

	[FieldOffset(16)]
	[ReferenceTable("QuestFlags")]
	public TRef TriggeredQuestFlag;

	[FieldOffset(32)]
	[ReferenceTable("QuestFlags")]
	public TRef Unk002;

	[FieldOffset(48)]
	public int Unk003;

	[FieldOffset(52)]
	[ElementType(typeof(int))]
	public TArray Unk004;

	[FieldOffset(68)]
	public TBool Unk005;

	[FieldOffset(69)]
	public TBool Unk006;

	[FieldOffset(70)]
	public TRef Unk007;

	[FieldOffset(86)]
	public TRef Unk008;

	[FieldOffset(102)]
	public TString Script;

	[FieldOffset(110)]
	public TRef Unk010;

	[FieldOffset(126)]
	public TRef Unk011;

	[FieldOffset(142)]
	public int Unk012;

}
