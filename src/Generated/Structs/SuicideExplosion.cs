using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SuicideExplosion
{
	[FieldOffset(0)]
	public int Id;

	[FieldOffset(4)]
	public TRef Unk001;

	[FieldOffset(20)]
	public TRef Unk002;

	[FieldOffset(36)]
	public TBool Unk003;

	[FieldOffset(37)]
	public TBool Unk004;

	[FieldOffset(38)]
	public TBool Unk005;

	[FieldOffset(39)]
	public TBool Unk006;

	[FieldOffset(40)]
	public int Unk007;

	[FieldOffset(44)]
	public TBool Unk008;

}
