using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistNPCBlueprintTypes
{
	[FieldOffset(0)]
	[ReferenceTable("NPCs")]
	public TRef NPCsKey;

	[FieldOffset(16)]
	public int Unk001;

}
