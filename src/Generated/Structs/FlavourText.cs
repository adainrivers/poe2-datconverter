using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct FlavourText
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public short Unk001;

	[FieldOffset(10)]
	public TString Text;

}
