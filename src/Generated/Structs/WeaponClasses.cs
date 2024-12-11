using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct WeaponClasses
{
	[FieldOffset(0)]
	[ReferenceTable("ItemClasses")]
	public TRef ItemClass;

	[FieldOffset(16)]
	public int Unk001;

}
