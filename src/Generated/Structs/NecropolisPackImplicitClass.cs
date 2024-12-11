using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NecropolisPackImplicitClass
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("NecropolisPackImplicits")]
	public TRef MoreImplicit;

	[FieldOffset(24)]
	[ReferenceTable("NecropolisPackImplicits")]
	public TRef LessImplicit;

}
