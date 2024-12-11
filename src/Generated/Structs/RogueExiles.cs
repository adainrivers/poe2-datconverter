using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct RogueExiles
{
	[FieldOffset(0)]
	[ReferenceTable("MonsterVarieties")]
	public TRef MonsterVarietiesKey;

	[FieldOffset(16)]
	public bool Unk001;

	[FieldOffset(17)]
	public TRef Unk002;

}
