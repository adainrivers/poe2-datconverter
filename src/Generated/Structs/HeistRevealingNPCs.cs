using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistRevealingNPCs
{
	[FieldOffset(0)]
	[ReferenceTable("NPCs")]
	public TRef NPCsKey;

	[FieldOffset(16)]
	public TString PortraitFile;

	[FieldOffset(24)]
	[ReferenceTable("NPCAudio")]
	[ElementType(typeof(TRef))]
	public TArray NPCAudioKey;

	[FieldOffset(40)]
	public int Unk003;

}
