using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct VillageUpgrades
{
	[FieldOffset(0)]
	public TRef Unk000;

	[FieldOffset(16)]
	public int Tier;

	[FieldOffset(20)]
	public TString Text;

	[FieldOffset(28)]
	public int Unk003;

	[FieldOffset(32)]
	[ElementType(typeof(TRef))]
	public TArray Unk004;

	[FieldOffset(48)]
	[ElementType(typeof(int))]
	public TArray Unk005;

	[FieldOffset(64)]
	public int Unk006;

	[FieldOffset(68)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TRef))]
	public TArray RuneItem;

	[FieldOffset(84)]
	[ElementType(typeof(int))]
	public TArray Unk008;

	[FieldOffset(100)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray Stats;

	[FieldOffset(116)]
	[ElementType(typeof(int))]
	public TArray StatsValues;

	[FieldOffset(132)]
	[ReferenceTable("NPCTextAudio")]
	public TRef UpgradeTextAudio;

}
