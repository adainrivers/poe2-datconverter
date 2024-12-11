using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MicrotransactionCursorVariations
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef Unk000;

	[FieldOffset(16)]
	public TRef Unk001;

	[FieldOffset(32)]
	public int Unk002;

}
