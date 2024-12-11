using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DelveBiomes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Name;

	[FieldOffset(16)]
	[ReferenceTable("WorldAreas")]
	[ElementType(typeof(TRef))]
	public TArray WorldAreasKeys;

	[FieldOffset(32)]
	public TString UIImage;

	[FieldOffset(40)]
	[ElementType(typeof(int))]
	public TArray SpawnWeight_Depth;

	[FieldOffset(56)]
	[ElementType(typeof(int))]
	public TArray SpawnWeight_Values;

	[FieldOffset(72)]
	[ElementType(typeof(int))]
	public TArray Unk006;

	[FieldOffset(88)]
	[ElementType(typeof(int))]
	public TArray Unk007;

	[FieldOffset(104)]
	public TString Art2D;

	[FieldOffset(112)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray AchievementItemsKeys;

	[FieldOffset(128)]
	public TBool Unk010;

	[FieldOffset(129)]
	[ElementType(typeof(int))]
	public TArray Unk011;

}
