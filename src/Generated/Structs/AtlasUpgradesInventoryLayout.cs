using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AtlasUpgradesInventoryLayout
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	[ReferenceTable("BaseItemTypes")]
	public TRef Voidstone;

	[FieldOffset(28)]
	public int Unk003;

	[FieldOffset(32)]
	public TString Objective;

	[FieldOffset(40)]
	[ReferenceTable("QuestFlags")]
	public TRef GrantAtlasUpgrade;

	[FieldOffset(56)]
	public TRef Unk006;

}
