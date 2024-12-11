using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AtlasPrimordialBosses
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	public int Unk002;

	[FieldOffset(16)]
	public int Unk003;

	[FieldOffset(20)]
	public int Unk004;

	[FieldOffset(24)]
	[ReferenceTable("MiscAnimated")]
	public TRef InfluenceComplete;

	[FieldOffset(40)]
	[ReferenceTable("BaseItemTypes")]
	public TRef MiniBossInvitation;

	[FieldOffset(56)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BossInvitation;

	[FieldOffset(72)]
	[ReferenceTable("QuestFlags")]
	public TRef PickUpKey;

	[FieldOffset(88)]
	public TRef Unk009;

	[FieldOffset(104)]
	public TRef Unk010;

	[FieldOffset(120)]
	[ReferenceTable("Tags")]
	public TRef Tag;

	[FieldOffset(136)]
	[ReferenceTable("MiscObjects")]
	public TRef Altar;

	[FieldOffset(152)]
	[ReferenceTable("MiscAnimated")]
	public TRef AltarActivated;

}
