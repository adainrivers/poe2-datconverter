using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DelveRobotVariations
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString AOFile;

	[FieldOffset(16)]
	[ElementType(typeof(TString))]
	public TArray Unk002;

	[FieldOffset(32)]
	public TRef Unk003;

	[FieldOffset(48)]
	public TRef Unk004;

}
