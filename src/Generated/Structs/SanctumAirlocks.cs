using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SanctumAirlocks
{
	[FieldOffset(0)]
	[ReferenceTable("SanctumFloors")]
	public TRef Floor;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	[ElementType(typeof(int))]
	public TArray Unk002;

	[FieldOffset(36)]
	[ReferenceTable("WorldAreas")]
	public TRef Area1;

	[FieldOffset(52)]
	[ReferenceTable("WorldAreas")]
	public TRef Area2;

}
