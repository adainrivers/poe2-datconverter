using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MiscEffectPacks
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString EPKFile;

	[FieldOffset(16)]
	public int Unk002;

	[FieldOffset(20)]
	public int Unk003;

	[FieldOffset(24)]
	public int Unk004;

	[FieldOffset(28)]
	[ReferenceTable("PreloadGroups")]
	[ElementType(typeof(TRef))]
	public TArray PreloadGroups;

	[FieldOffset(44)]
	public bool Unk006;

	[FieldOffset(45)]
	public TString PlayerOnly_EPKFile;

	[FieldOffset(53)]
	public bool Unk008;

}
