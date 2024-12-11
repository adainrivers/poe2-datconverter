using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistStorageLayout
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("BaseItemTypes")]
	public TRef StoredItem;

	[FieldOffset(24)]
	public TBool Unk002;

	[FieldOffset(25)]
	public TString ButtonFile;

	[FieldOffset(33)]
	public int SlotSize;

	[FieldOffset(37)]
	[ReferenceTable("HeistJobs")]
	public TRef HeistJobsKey;

	[FieldOffset(53)]
	public int Width;

	[FieldOffset(57)]
	public int Height;

	[FieldOffset(61)]
	public int Unk008;

	[FieldOffset(65)]
	public int Unk009;

	[FieldOffset(69)]
	public int Unk010;

	[FieldOffset(73)]
	public int Unk011;

	[FieldOffset(77)]
	[ReferenceTable("ItemClasses")]
	public TRef ItemClass;

}
