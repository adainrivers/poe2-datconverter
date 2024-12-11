using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemisedNecropolisPacks
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef Item;

	[FieldOffset(16)]
	[ReferenceTable("NecropolisPacks")]
	public TRef Pack;

	[FieldOffset(32)]
	public TString Description;

}
