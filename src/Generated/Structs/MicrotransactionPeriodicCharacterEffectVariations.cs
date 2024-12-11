using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MicrotransactionPeriodicCharacterEffectVariations
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString AOFile;

	[FieldOffset(16)]
	[ReferenceTable("MiscObjects")]
	public TRef MiscObject;

	[FieldOffset(32)]
	public int Unk003;

}
