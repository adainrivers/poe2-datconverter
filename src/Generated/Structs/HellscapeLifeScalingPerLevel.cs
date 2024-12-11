using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HellscapeLifeScalingPerLevel
{
	[FieldOffset(0)]
	public int AreaLevel;

	[FieldOffset(4)]
	public int Scale;

}
