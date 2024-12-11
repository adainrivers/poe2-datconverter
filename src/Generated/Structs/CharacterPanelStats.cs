using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CharacterPanelStats
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Text;

	[FieldOffset(16)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray StatsKeys1;

	[FieldOffset(32)]
	[ReferenceTable("CharacterPanelDescriptionModes")]
	public TRef CharacterPanelDescriptionModesKey;

	[FieldOffset(48)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray StatsKeys2;

	[FieldOffset(64)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray StatsKeys3;

	[FieldOffset(80)]
	[ReferenceTable("CharacterPanelTabs")]
	public TRef CharacterPanelTabsKey;

	[FieldOffset(96)]
	public bool Unk007;

	[FieldOffset(97)]
	[ElementType(typeof(int))]
	public TArray Unk008;

	[FieldOffset(113)]
	public int Unk009;

}
