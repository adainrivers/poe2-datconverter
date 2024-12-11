using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ExpeditionCurrency
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItemType;

	[FieldOffset(16)]
	public int Tier;

	[FieldOffset(20)]
	[ReferenceTable("ExpeditionNPCs")]
	public TRef NPC;

	[FieldOffset(36)]
	[ReferenceTable("SoundEffects")]
	public TRef LootSound;

}
