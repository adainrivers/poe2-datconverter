using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct VillageUniqueDisenchantValues
{
	[FieldOffset(0)]
	[ReferenceTable("Words")]
	public TRef UniqueName;

	[FieldOffset(16)]
	public float Value;

}
