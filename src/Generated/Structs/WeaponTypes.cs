using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct WeaponTypes
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItemTypesKey;

	[FieldOffset(16)]
	public int Critical;

	[FieldOffset(20)]
	public int Speed;

	[FieldOffset(24)]
	public int DamageMin;

	[FieldOffset(28)]
	public int DamageMax;

	[FieldOffset(32)]
	public int RangeMax;

	[FieldOffset(36)]
	public int Unk006;

}
