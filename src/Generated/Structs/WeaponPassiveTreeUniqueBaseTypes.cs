using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct WeaponPassiveTreeUniqueBaseTypes
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef UniqueBase;

	[FieldOffset(16)]
	public int Unk001;

}
