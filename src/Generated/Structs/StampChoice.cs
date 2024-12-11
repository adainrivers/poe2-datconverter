using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct StampChoice
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TRef Unk001;

	[FieldOffset(24)]
	public int Unk002;

	[FieldOffset(28)]
	public TString Effect;

	[FieldOffset(36)]
	public TString Icon;

	[FieldOffset(44)]
	public TRef Unk005;

	[FieldOffset(60)]
	[ElementType(typeof(int))]
	public TArray Unk006;

	[FieldOffset(76)]
	public int Unk007;

}
