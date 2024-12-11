using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SalvageBoxes
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItemType;

	[FieldOffset(16)]
	public TString Id;

	[FieldOffset(24)]
	public TString Unk002;

}
