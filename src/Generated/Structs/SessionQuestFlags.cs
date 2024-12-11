using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SessionQuestFlags
{
	[FieldOffset(0)]
	[ReferenceTable("QuestFlags")]
	public TRef QuestFlag;

}
