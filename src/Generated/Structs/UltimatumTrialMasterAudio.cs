using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct UltimatumTrialMasterAudio
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int Variant;

	[FieldOffset(12)]
	public int Unk002;

	[FieldOffset(16)]
	public int Unk003;

	[FieldOffset(20)]
	[ReferenceTable("NPCTextAudio")]
	public TRef TextAudio;

	[FieldOffset(36)]
	public int RoundsMin;

	[FieldOffset(40)]
	public int RoundsMax;

}
