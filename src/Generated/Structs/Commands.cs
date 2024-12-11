using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Commands
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Command;

	[FieldOffset(16)]
	public TBool Unk002;

	[FieldOffset(17)]
	public TString EnglishCommand;

	[FieldOffset(25)]
	public TString Description;

	[FieldOffset(33)]
	public TBool Unk005;

}
