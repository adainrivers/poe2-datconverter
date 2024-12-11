using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct UniqueJewelLimits
{
	[FieldOffset(0)]
	[ReferenceTable("Words")]
	public TRef JewelName;

	[FieldOffset(16)]
	public int Limit;

}
