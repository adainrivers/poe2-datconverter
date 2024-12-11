using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct RecipeUnlockObjects
{
	[FieldOffset(0)]
	[ReferenceTable("WorldAreas")]
	public TRef WorldAreasKey;

	[FieldOffset(16)]
	public TString InheritsFrom;

	[FieldOffset(24)]
	public int RecipeId;

}
