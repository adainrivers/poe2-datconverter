using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Inventories
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int InventoryIdKey;

	[FieldOffset(12)]
	[ReferenceTable("InventoryType")]
	[EnumName("InventoryType")]
	public TEnum InventoryTypeKey;

	[FieldOffset(16)]
	public bool Unk003;

	[FieldOffset(17)]
	public bool Unk004;

	[FieldOffset(18)]
	public int Unk005;

	[FieldOffset(22)]
	public bool Unk006;

	[FieldOffset(23)]
	public int Unk007;

}
