using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AfflictionRewardMapMods
{
	[FieldOffset(0)]
	[ReferenceTable("Mods")]
	public TRef ModsKey;

	[FieldOffset(16)]
	public TBool Unk001;

}
