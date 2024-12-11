using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LakeMetaOptions
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ElementType(typeof(int))]
	public TArray Unk001;

}
