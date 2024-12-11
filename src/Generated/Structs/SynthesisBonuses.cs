using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SynthesisBonuses
{
	[FieldOffset(0)]
	[ReferenceTable("Mods")]
	public TRef ModsKey;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	public int Unk002;

	[FieldOffset(24)]
	public int Unk003;

	[FieldOffset(28)]
	public int Unk004;

	[FieldOffset(32)]
	public int Unk005;

	[FieldOffset(36)]
	public TBool Unk006;

	[FieldOffset(37)]
	public TBool Unk007;

}
