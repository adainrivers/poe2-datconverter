using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MicrotransactionEquippedIconVariations
{
	[FieldOffset(0)]
	public TRef Unk000;

	[FieldOffset(16)]
	[ElementType(typeof(TString))]
	public TArray DDSFiles;

	[FieldOffset(32)]
	[ElementType(typeof(int))]
	public TArray Unk002;

}
