using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TalismanMonsterMods
{
	[FieldOffset(0)]
	[ReferenceTable("ModType")]
	public TRef ModTypeKey;

	[FieldOffset(16)]
	[ReferenceTable("Mods")]
	public TRef ModsKey;

}
