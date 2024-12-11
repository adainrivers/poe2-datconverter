using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct QuestStates
{
	[FieldOffset(0)]
	[ReferenceTable("Quest")]
	public TRef Quest;

	[FieldOffset(16)]
	public int Order;

	[FieldOffset(20)]
	[ReferenceTable("QuestFlags")]
	[ElementType(typeof(TRef))]
	public TArray FlagsPresent;

	[FieldOffset(36)]
	[ReferenceTable("QuestFlags")]
	[ElementType(typeof(TRef))]
	public TArray FlagsMissing;

	[FieldOffset(52)]
	public TString Text;

	[FieldOffset(60)]
	public bool Unk005;

	[FieldOffset(61)]
	public TString Message;

	[FieldOffset(69)]
	[ReferenceTable("MapPins")]
	[ElementType(typeof(TRef))]
	public TArray MapPinsKeys1;

}
