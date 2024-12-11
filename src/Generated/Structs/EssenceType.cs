using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct EssenceType
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int EssenceType_001;

	[FieldOffset(12)]
	public TBool IsCorruptedEssence;

	[FieldOffset(13)]
	[ReferenceTable("Words")]
	public TRef WordsKey;

	[FieldOffset(29)]
	public TRef Unk004;

}
