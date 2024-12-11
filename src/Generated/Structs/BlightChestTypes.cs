using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BlightChestTypes
{
	[FieldOffset(0)]
	[ReferenceTable("Chests")]
	public TRef ChestsKey;

}
