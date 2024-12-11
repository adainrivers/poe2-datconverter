using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LeagueProgressQuestFlags
{
	[FieldOffset(0)]
	[ReferenceTable("QuestFlags")]
	public TRef QuestFlag;

	[FieldOffset(16)]
	[ReferenceTable("ClientStrings")]
	public TRef CompletionString;

	[FieldOffset(32)]
	public TString Boss;

	[FieldOffset(40)]
	public bool Unk003;

}
