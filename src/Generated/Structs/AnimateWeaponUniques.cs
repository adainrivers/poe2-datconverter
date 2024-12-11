using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AnimateWeaponUniques
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("ItemVisualIdentity")]
	public TRef ItemVisualIdentity;

	[FieldOffset(24)]
	[ReferenceTable("ItemClasses")]
	public TRef ItemClass;

	[FieldOffset(40)]
	public int Unk003;

}
