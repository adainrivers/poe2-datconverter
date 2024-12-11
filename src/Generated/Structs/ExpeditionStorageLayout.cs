using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ExpeditionStorageLayout
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
	public int Unk004;

	[FieldOffset(36)]
	public int Unk005;

	[FieldOffset(40)]
	public int Width;

	[FieldOffset(44)]
	public int Height;

	[FieldOffset(48)]
	public int Unk008;

	[FieldOffset(52)]
	public TBool Unk009;

	[FieldOffset(53)]
	public TRef Unk010;

}
