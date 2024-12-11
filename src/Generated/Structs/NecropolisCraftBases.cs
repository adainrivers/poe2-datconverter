using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NecropolisCraftBases
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItem;

	[FieldOffset(24)]
	[ReferenceTable("NecropolisUniqueCrafts")]
	public TRef UniqueCraft;

	[FieldOffset(40)]
	public bool Unk003;

	[FieldOffset(41)]
	public int Unk004;

	[FieldOffset(45)]
	[ReferenceTable("NecropolisCraftItemTypes")]
	public TRef CraftItemType;

	[FieldOffset(61)]
	public TString Name;

	[FieldOffset(69)]
	[ReferenceTable("Stats")]
	public TRef CraftTag;

	[FieldOffset(85)]
	public bool Unk008;

}
