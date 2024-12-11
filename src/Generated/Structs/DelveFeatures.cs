using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DelveFeatures
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Name;

	[FieldOffset(16)]
	[ElementType(typeof(int))]
	public TArray SpawnWeight;

	[FieldOffset(32)]
	[ReferenceTable("WorldAreas")]
	public TRef WorldAreasKey;

	[FieldOffset(48)]
	public TString Image;

	[FieldOffset(56)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray AchievementItemsKeys;

	[FieldOffset(72)]
	[ElementType(typeof(int))]
	public TArray Unk006;

	[FieldOffset(88)]
	[ElementType(typeof(int))]
	public TArray MinDepth;

	[FieldOffset(104)]
	public TString Description;

	[FieldOffset(112)]
	public int Unk009;

	[FieldOffset(116)]
	[ElementType(typeof(int))]
	public TArray Unk010;

	[FieldOffset(132)]
	[ElementType(typeof(int))]
	public TArray Unk011;

	[FieldOffset(148)]
	[ElementType(typeof(int))]
	public TArray Unk012;

	[FieldOffset(164)]
	[ElementType(typeof(int))]
	public TArray Unk013;

}
