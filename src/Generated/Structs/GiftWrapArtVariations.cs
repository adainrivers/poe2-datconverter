using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GiftWrapArtVariations
{
	[FieldOffset(0)]
	public int Width;

	[FieldOffset(4)]
	public int Height;

	[FieldOffset(8)]
	public int Unk002;

	[FieldOffset(12)]
	[ReferenceTable("BaseItemTypes")]
	public TRef Item;

}
