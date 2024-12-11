using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CrucibleTags
{
	[FieldOffset(0)]
	public TString Tag;

	[FieldOffset(8)]
	public TBool Unk001;

}
