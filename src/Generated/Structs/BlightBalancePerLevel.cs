using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BlightBalancePerLevel
{
	[FieldOffset(0)]
	public int Level;

	[FieldOffset(4)]
	public int Unk001;

	[FieldOffset(8)]
	[ElementType(typeof(int))]
	public TArray Unk002;

	[FieldOffset(24)]
	public int Unk003;

	[FieldOffset(28)]
	public int Unk004;

	[FieldOffset(32)]
	public int Unk005;

	[FieldOffset(36)]
	public int Unk006;

	[FieldOffset(40)]
	public int Unk007;

	[FieldOffset(44)]
	public int Unk008;

}
