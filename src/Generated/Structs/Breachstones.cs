using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Breachstones
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseType;

	[FieldOffset(16)]
	public int MapTierEquivalent;

	[FieldOffset(20)]
	public int Unk002;

	[FieldOffset(24)]
	[ReferenceTable("BaseItemTypes")]
	public TRef UpgradesTo;

	[FieldOffset(40)]
	[ReferenceTable("BaseItemTypes")]
	public TRef UpgradeCurrency;

}
