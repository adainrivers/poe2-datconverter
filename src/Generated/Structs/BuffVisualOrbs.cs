using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BuffVisualOrbs
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("BuffVisualOrbTypes")]
	public TRef BuffVisualOrbTypesKey;

	[FieldOffset(24)]
	[ReferenceTable("BuffVisualOrbArt")]
	[ElementType(typeof(TRef))]
	public TArray BuffVisualOrbArtKeys;

	[FieldOffset(40)]
	[ReferenceTable("BuffVisualOrbArt")]
	[ElementType(typeof(TRef))]
	public TArray Player_BuffVisualOrbArtKeys;

	[FieldOffset(56)]
	[ReferenceTable("BuffVisualOrbArt")]
	[ElementType(typeof(TRef))]
	public TArray BuffVisualOrbArtKeys2;

}
