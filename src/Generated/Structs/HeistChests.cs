using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistChests
{
	[FieldOffset(0)]
	[ReferenceTable("Chests")]
	public TRef ChestsKey;

	[FieldOffset(16)]
	public int Weight;

	[FieldOffset(20)]
	[ReferenceTable("HeistAreas")]
	[ElementType(typeof(TRef))]
	public TArray HeistAreasKey;

	[FieldOffset(36)]
	[ReferenceTable("HeistChestTypes")]
	[EnumName("HeistChestTypes")]
	public TEnum HeistChestTypesKey;

}
