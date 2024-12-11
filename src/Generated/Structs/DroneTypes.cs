using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DroneTypes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("QuestFlags")]
	public TRef Unk001;

	[FieldOffset(24)]
	[ReferenceTable("MonsterVarieties")]
	public TRef Unk002;

	[FieldOffset(40)]
	public TString DeployText;

	[FieldOffset(48)]
	public TString Unk004;

	[FieldOffset(56)]
	[ReferenceTable("Stats")]
	public TRef UnlockedStat;

	[FieldOffset(72)]
	public TString SocketableText;

	[FieldOffset(80)]
	public TString NotPoweredText;

}
