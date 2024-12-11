using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SentinelStorageLayout
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("BaseItemTypes")]
	public TRef StoredItem;

	[FieldOffset(24)]
	[ReferenceTable("DroneTypes")]
	public TRef DroneType;

	[FieldOffset(40)]
	public bool Unk003;

	[FieldOffset(41)]
	public TString TabIcon;

	[FieldOffset(49)]
	public int XOffset;

	[FieldOffset(53)]
	public int YOffset;

	[FieldOffset(57)]
	public int Unk007;

	[FieldOffset(61)]
	public int Unk008;

	[FieldOffset(65)]
	public int Width;

	[FieldOffset(69)]
	public int Height;

	[FieldOffset(73)]
	public int SlotSize;

	[FieldOffset(77)]
	[ReferenceTable("ItemClasses")]
	public TRef Unk012;

}
