using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AlternateQualityTypes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Description;

	[FieldOffset(16)]
	[ReferenceTable("BaseItemTypes")]
	public TRef Item;

	[FieldOffset(32)]
	public TRef Unk003;

	[FieldOffset(48)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray MapStats;

	[FieldOffset(64)]
	public int Unk005;

	[FieldOffset(68)]
	public bool IsCatalyst;

	[FieldOffset(69)]
	public short HASH16;

	[FieldOffset(71)]
	[ReferenceTable("Mods")]
	public TRef CatalystMod;

}
