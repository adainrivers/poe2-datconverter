using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HideoutDoodadTags
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ElementType(typeof(int))]
	public TArray Unk001;

	[FieldOffset(24)]
	[ElementType(typeof(int))]
	public TArray Unk002;

	[FieldOffset(40)]
	public TString Name;

}
