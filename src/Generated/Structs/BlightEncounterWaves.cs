using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BlightEncounterWaves
{
	[FieldOffset(0)]
	public TString MonsterSpawnerId;

	[FieldOffset(8)]
	[ReferenceTable("BlightEncounterTypes")]
	public TRef EncounterType;

	[FieldOffset(24)]
	public int Unk002;

	[FieldOffset(28)]
	public int Unk003;

	[FieldOffset(32)]
	public int Unk004;

	[FieldOffset(36)]
	public int Wave;

}
