using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ExperienceLevels
{
	[FieldOffset(0)]
	public TString Unk000;

	[FieldOffset(8)]
	public int Level;

	[FieldOffset(12)]
	public uint Experience;

}
