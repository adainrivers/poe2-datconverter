using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct IncursionUniqueUpgradeComponents
{
	[FieldOffset(0)]
	[ReferenceTable("Words")]
	public TRef BaseUnique;

	[FieldOffset(16)]
	[ReferenceTable("BaseItemTypes")]
	public TRef UpgradeCurrency;

}
