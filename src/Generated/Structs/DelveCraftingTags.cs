using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DelveCraftingTags
{
	[FieldOffset(0)]
	[ReferenceTable("Tags")]
	public TRef TagsKey;

	[FieldOffset(16)]
	public TString ItemClass;

}
