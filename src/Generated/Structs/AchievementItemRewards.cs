using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AchievementItemRewards
{
	[FieldOffset(0)]
	[ReferenceTable("AchievementItems")]
	public TRef AchievementItemsKey;

	[FieldOffset(16)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItemTypesKey;

	[FieldOffset(32)]
	public TString Message;

	[FieldOffset(40)]
	public TString Id;

}
