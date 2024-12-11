using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DelveStashTabLayout
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("BaseItemTypes")]
	public TRef StoredItem;

	[FieldOffset(24)]
	public int XOffset;

	[FieldOffset(28)]
	public int YOffset;

	[FieldOffset(32)]
	public int FirstSlotIndex;

	[FieldOffset(36)]
	public int Width;

	[FieldOffset(40)]
	public int Height;

	[FieldOffset(44)]
	public int SlotSize;

	[FieldOffset(48)]
	public TBool HideIfEmpty;

	[FieldOffset(49)]
	public TString Image;

}
