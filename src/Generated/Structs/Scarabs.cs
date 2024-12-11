using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Scarabs
{
	[FieldOffset(0)]
	[ReferenceTable("ScarabTypes")]
	public TRef Type;

	[FieldOffset(16)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TRef))]
	public TArray Items;

}
