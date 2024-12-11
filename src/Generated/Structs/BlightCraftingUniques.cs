using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BlightCraftingUniques
{
	[FieldOffset(0)]
	[ReferenceTable("Words")]
	public TRef WordsKey;

}
