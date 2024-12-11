using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemExperiencePerLevel
{
	[FieldOffset(0)]
	[ReferenceTable("ItemExperienceTypes")]
	public TRef ItemExperienceType;

	[FieldOffset(16)]
	public int ItemCurrentLevel;

	[FieldOffset(20)]
	public int Experience;

}
