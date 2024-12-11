using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MysteryBoxes
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItemTypesKey;

	[FieldOffset(16)]
	public TString BK2File;

	[FieldOffset(24)]
	public TString BoxId;

	[FieldOffset(32)]
	public TString BundleId;

	[FieldOffset(40)]
	public TBool Unk004;

}
