using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ProjectilesArtVariations
{
	[FieldOffset(0)]
	public TString Projectile;

	[FieldOffset(8)]
	public int Variant;

	[FieldOffset(12)]
	[ElementType(typeof(int))]
	public TArray Unk002;

	[FieldOffset(28)]
	public int Unk003;

	[FieldOffset(32)]
	public TRef Unk004;

}
