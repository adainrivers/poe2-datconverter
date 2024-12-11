using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AchievementSetsDisplay
{
	[FieldOffset(0)]
	public int Id;

	[FieldOffset(4)]
	public TString Title;

}
