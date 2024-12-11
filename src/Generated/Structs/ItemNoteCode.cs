using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemNoteCode
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItem;

	[FieldOffset(16)]
	public TString Code;

	[FieldOffset(24)]
	public int Order1;

	[FieldOffset(28)]
	public bool Show;

	[FieldOffset(29)]
	public int Order2;

}
