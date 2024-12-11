using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NPCPortraits
{
	[FieldOffset(0)]
	public TString Name;

	[FieldOffset(8)]
	public TString PortraitFile;

	[FieldOffset(16)]
	public int Unk002;

	[FieldOffset(20)]
	public int Unk003;

}
