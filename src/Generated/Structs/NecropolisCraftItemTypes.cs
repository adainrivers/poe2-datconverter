using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NecropolisCraftItemTypes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString ExorciseIcon;

	[FieldOffset(16)]
	public TString Name;

	[FieldOffset(24)]
	public int Unk003;

	[FieldOffset(28)]
	public TString IllustratuionIcon;

	[FieldOffset(36)]
	[ReferenceTable("NPCTextAudio")]
	public TRef TextAudioLong;

	[FieldOffset(52)]
	[ReferenceTable("AchievementItems")]
	public TRef Achievements;

	[FieldOffset(68)]
	[ReferenceTable("NPCTextAudio")]
	public TRef TextAudioShort;

	[FieldOffset(84)]
	public TRef Unk008;

}
