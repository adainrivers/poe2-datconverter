using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct VoteType
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Text;

	[FieldOffset(16)]
	public TString AcceptText;

	[FieldOffset(24)]
	public TString RejectText;

	[FieldOffset(32)]
	public int Unk004;

	[FieldOffset(36)]
	public int Unk005;

	[FieldOffset(40)]
	public int Unk006;

	[FieldOffset(44)]
	public int Unk007;

}
