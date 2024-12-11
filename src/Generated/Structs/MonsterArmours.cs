using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterArmours
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString ArtString_SMFile;

}
