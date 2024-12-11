using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HellscapeAreaPacks
{
	[FieldOffset(0)]
	[ReferenceTable("WorldAreas")]
	public TRef WorldArea;

	[FieldOffset(16)]
	[ReferenceTable("MonsterPacks")]
	[ElementType(typeof(TRef))]
	public TArray MonsterPacks;

	[FieldOffset(32)]
	public int Unk002;

	[FieldOffset(36)]
	public int Unk003;

}
