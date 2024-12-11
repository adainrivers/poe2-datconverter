using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterSpawnerOverrides
{
	[FieldOffset(0)]
	public TRef Unk000;

	[FieldOffset(16)]
	[ReferenceTable("MonsterVarieties")]
	public TRef Base_MonsterVarietiesKey;

	[FieldOffset(32)]
	[ReferenceTable("MonsterVarieties")]
	public TRef Override_MonsterVarietiesKey;

}
