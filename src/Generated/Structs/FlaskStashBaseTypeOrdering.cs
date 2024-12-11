using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct FlaskStashBaseTypeOrdering
{
	[FieldOffset(0)]
	[ReferenceTable("Flasks")]
	public TRef Flask;

	[FieldOffset(16)]
	public int Order;

}
