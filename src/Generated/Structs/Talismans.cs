using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Talismans
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItemTypesKey;

	[FieldOffset(16)]
	public int SpawnWeight;

	[FieldOffset(20)]
	[ReferenceTable("Mods")]
	public TRef ModsKey;

	[FieldOffset(36)]
	public int Tier;

	[FieldOffset(40)]
	public bool Unk004;

	[FieldOffset(41)]
	public bool Unk005;

	[FieldOffset(42)]
	public TRef Unk006;

	[FieldOffset(58)]
	public TRef Unk007;

	[FieldOffset(74)]
	public int Unk008;

}
