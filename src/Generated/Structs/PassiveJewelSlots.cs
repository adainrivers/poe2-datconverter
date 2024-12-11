using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PassiveJewelSlots
{
	[FieldOffset(0)]
	[ReferenceTable("PassiveSkills")]
	public TRef Slot;

	[FieldOffset(16)]
	[ReferenceTable("PassiveTreeExpansionJewelSizes")]
	public TRef ClusterJewelSize;

	[FieldOffset(32)]
	public int Unk002;

	[FieldOffset(36)]
	[ReferenceTable("PassiveJewelSlots")]
	public TRef ReplacesSlot;

	[FieldOffset(44)]
	[ReferenceTable("PassiveSkills")]
	public TRef ProxySlot;

	[FieldOffset(60)]
	[ElementType(typeof(int))]
	public TArray StartIndices;

	[FieldOffset(76)]
	public bool Unk006;

}
