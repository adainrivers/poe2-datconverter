using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HellscapeModificationInventoryLayout
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int Column;

	[FieldOffset(12)]
	public int Row;

	[FieldOffset(16)]
	public bool IsMapSlot;

	[FieldOffset(17)]
	public int Unk004;

	[FieldOffset(21)]
	public int Width;

	[FieldOffset(25)]
	public int Height;

	[FieldOffset(29)]
	[ReferenceTable("Stats")]
	public TRef Stat;

	[FieldOffset(45)]
	public int StatValue;

	[FieldOffset(49)]
	[ReferenceTable("HellscapePassives")]
	public TRef UnlockedWith;

	[FieldOffset(65)]
	[ReferenceTable("Quest")]
	public TRef Quest;

}
