using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ExtraTerrainFeatures
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ElementType(typeof(TString))]
	public TArray ArmFiles;

	[FieldOffset(24)]
	[ElementType(typeof(TString))]
	public TArray TdtFiles;

	[FieldOffset(40)]
	public bool Unk003;

	[FieldOffset(41)]
	[ElementType(typeof(TString))]
	public TArray Unk004;

	[FieldOffset(57)]
	[ElementType(typeof(int))]
	public TArray Unk005;

	[FieldOffset(73)]
	[ReferenceTable("ExtraTerrainFeatures")]
	public TRef Unk006;

	[FieldOffset(81)]
	[ReferenceTable("WorldAreas")]
	public TRef WorldAreasKey;

	[FieldOffset(97)]
	public bool Unk008;

	[FieldOffset(98)]
	public int Unk009;

}
