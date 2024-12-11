using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TieredMicrotransactionsVisuals
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef MTX;

	[FieldOffset(16)]
	public int Tier;

	[FieldOffset(20)]
	public TString Description;

	[FieldOffset(28)]
	public TString DDSFile;

	[FieldOffset(36)]
	public int Unk004;

	[FieldOffset(40)]
	public TString Unk005;

}
