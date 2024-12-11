using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct FragmentStashTabLayout
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int XOffset;

	[FieldOffset(12)]
	public int YOffset;

	[FieldOffset(16)]
	public int FirstSlotIndex;

	[FieldOffset(20)]
	public int Width;

	[FieldOffset(24)]
	public int Height;

	[FieldOffset(28)]
	public TBool Unk006;

	[FieldOffset(29)]
	public int Tab;

	[FieldOffset(33)]
	public int SlotSize;

	[FieldOffset(37)]
	public TBool HideIfEmpty;

	[FieldOffset(38)]
	public int Subtab;

	[FieldOffset(42)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TRef))]
	public TArray StoredItems;

	[FieldOffset(58)]
	public TBool Unk012;

	[FieldOffset(59)]
	public TString Unk013;

	[FieldOffset(67)]
	public int Unk014;

}
