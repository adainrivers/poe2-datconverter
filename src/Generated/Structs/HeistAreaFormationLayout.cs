using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistAreaFormationLayout
{
	[FieldOffset(0)]
	[ReferenceTable("HeistAreas")]
	public TRef HeistAreasKey;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	public int Unk002;

	[FieldOffset(24)]
	public int Unk003;

	[FieldOffset(28)]
	public int Unk004;

	[FieldOffset(32)]
	public int Unk005;

	[FieldOffset(36)]
	public int Unk006;

	[FieldOffset(40)]
	public int Unk007;

	[FieldOffset(44)]
	public int Unk008;

	[FieldOffset(48)]
	public int Unk009;

	[FieldOffset(52)]
	public bool Unk010;

	[FieldOffset(53)]
	public int Unk011;

	[FieldOffset(57)]
	public int Unk012;

}
