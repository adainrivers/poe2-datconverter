using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct RareMonsterLifeScalingPerLevel
{
	[FieldOffset(0)]
	public int Level;

	[FieldOffset(4)]
	public int Life;

}
