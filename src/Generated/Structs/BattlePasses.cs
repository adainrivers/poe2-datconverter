using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BattlePasses
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("LeagueCategory")]
	[EnumName("LeagueCategory")]
	public TEnum LeagueCategory;

	[FieldOffset(12)]
	public TString International_BK2File;

	[FieldOffset(20)]
	public TString China_BK2File;

	[FieldOffset(28)]
	public int MapCompletionCount;

	[FieldOffset(32)]
	public TBool Unk005;

	[FieldOffset(33)]
	public TString Id2;

}
