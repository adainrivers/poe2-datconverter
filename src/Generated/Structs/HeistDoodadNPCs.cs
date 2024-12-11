using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistDoodadNPCs
{
	[FieldOffset(0)]
	[ReferenceTable("NPCs")]
	public TRef NPCsKey;

	[FieldOffset(16)]
	public TRef Unk001;

	[FieldOffset(32)]
	public TRef Unk002;

	[FieldOffset(48)]
	public int Unk003;

	[FieldOffset(52)]
	public int Unk004;

	[FieldOffset(56)]
	public int Unk005;

	[FieldOffset(60)]
	public TString AOFile;

	[FieldOffset(68)]
	public TString Stance;

	[FieldOffset(76)]
	[ReferenceTable("BetrayalTargets")]
	public TRef BetrayalTargetsKey;

}
