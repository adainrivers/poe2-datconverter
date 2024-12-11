using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapFragmentMods
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItemTypesKey;

	[FieldOffset(16)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TRef))]
	public TArray ModsKeys;

	[FieldOffset(32)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray AchievementItemsKey;

	[FieldOffset(48)]
	public int MapFragmentFamilies;

	[FieldOffset(52)]
	public bool Unk004;

	[FieldOffset(53)]
	public bool Unk005;

	[FieldOffset(54)]
	public bool Unk006;

	[FieldOffset(55)]
	public bool Unk007;

	[FieldOffset(56)]
	public bool Unk008;

	[FieldOffset(57)]
	public bool Unk009;

	[FieldOffset(58)]
	public int MinAreaLevel;

	[FieldOffset(62)]
	public int Unk011;

	[FieldOffset(66)]
	public int MapFragmentLimit;

	[FieldOffset(70)]
	public bool Unk013;

}
