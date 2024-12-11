using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MicrotransactionRarityDisplay
{
	[FieldOffset(0)]
	public TString Rarity;

	[FieldOffset(8)]
	public TRef Unk001;

	[FieldOffset(24)]
	public TString Unk002;

	[FieldOffset(32)]
	public TString Unk003;

}
