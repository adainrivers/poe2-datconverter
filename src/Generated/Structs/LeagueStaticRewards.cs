using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LeagueStaticRewards
{
	[FieldOffset(0)]
	public int Unk000;

	[FieldOffset(4)]
	public int Unk001;

	[FieldOffset(8)]
	public int Unk002;

	[FieldOffset(12)]
	public TRef Unk003;

	[FieldOffset(28)]
	public TRef Unk004;

	[FieldOffset(44)]
	public int Unk005;

	[FieldOffset(48)]
	public int Unk006;

	[FieldOffset(52)]
	public bool Unk007;

}
