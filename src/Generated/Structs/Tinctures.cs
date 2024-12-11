using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Tinctures
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItem;

	[FieldOffset(16)]
	public int DebuffInterval;

	[FieldOffset(20)]
	public int Cooldown;

}
