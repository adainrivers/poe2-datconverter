using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Notifications
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public bool Unk001;

	[FieldOffset(9)]
	public bool Unk002;

	[FieldOffset(10)]
	public TString Message;

	[FieldOffset(18)]
	public TString Unk004;

	[FieldOffset(26)]
	public int Unk005;

	[FieldOffset(30)]
	public bool Unk006;

	[FieldOffset(31)]
	public bool Unk007;

}
