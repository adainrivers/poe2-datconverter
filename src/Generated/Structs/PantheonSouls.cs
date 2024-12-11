using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PantheonSouls
{
	[FieldOffset(0)]
	[ReferenceTable("WorldAreas")]
	public TRef WorldArea;

	[FieldOffset(16)]
	[ReferenceTable("BaseItemTypes")]
	public TRef CapturedVessel;

	[FieldOffset(32)]
	[ReferenceTable("QuestFlags")]
	public TRef QuestFlagUpgrade;

	[FieldOffset(48)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TRef))]
	public TArray CapturedMonster;

	[FieldOffset(64)]
	[ReferenceTable("PantheonPanelLayout")]
	public TRef PanelLayout;

	[FieldOffset(80)]
	public TString CapturedMonsterDescription;

	[FieldOffset(88)]
	public int Unk006;

	[FieldOffset(92)]
	[ReferenceTable("QuestFlags")]
	public TRef QuestFlagDowngrade;

}
