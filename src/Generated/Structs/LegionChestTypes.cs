using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LegionChestTypes
{
	[FieldOffset(0)]
	[ReferenceTable("MonsterVarieties")]
	public TRef Unk000;

	[FieldOffset(16)]
	[ReferenceTable("Chests")]
	public TRef Chest;

	[FieldOffset(32)]
	[ReferenceTable("Chests")]
	public TRef HardmodeChest;

	[FieldOffset(48)]
	public int Unk003;

	[FieldOffset(52)]
	[ReferenceTable("LegionFactions")]
	public TRef Faction;

}
