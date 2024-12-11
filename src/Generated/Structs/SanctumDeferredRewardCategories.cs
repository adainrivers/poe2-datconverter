using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SanctumDeferredRewardCategories
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef Item;

	[FieldOffset(16)]
	public TString NamePlural;

	[FieldOffset(24)]
	public TString ScriptReward;

}
