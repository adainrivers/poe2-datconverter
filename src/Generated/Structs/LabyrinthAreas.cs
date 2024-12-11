using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LabyrinthAreas
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("WorldAreas")]
	[ElementType(typeof(TRef))]
	public TArray Normal_WorldAreasKeys;

	[FieldOffset(24)]
	[ReferenceTable("WorldAreas")]
	[ElementType(typeof(TRef))]
	public TArray Cruel_WorldAreasKeys;

	[FieldOffset(40)]
	[ReferenceTable("WorldAreas")]
	[ElementType(typeof(TRef))]
	public TArray Merciless_WorldAreasKeys;

	[FieldOffset(56)]
	[ReferenceTable("WorldAreas")]
	[ElementType(typeof(TRef))]
	public TArray Endgame_WorldAreasKeys;

	[FieldOffset(72)]
	public int Unk005;

}
