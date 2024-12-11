using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ExpeditionDeals
{
	[FieldOffset(0)]
	public int Id;

	[FieldOffset(4)]
	public TString Function;

	[FieldOffset(12)]
	public TString Arguments;

	[FieldOffset(20)]
	[ReferenceTable("NPCTextAudio")]
	public TRef TextAudio;

	[FieldOffset(36)]
	public TString Description;

	[FieldOffset(44)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray BuyAchievements;

	[FieldOffset(60)]
	public TRef Unk006;

	[FieldOffset(76)]
	[ReferenceTable("ExpeditionDealFamilies")]
	[EnumName("ExpeditionDealFamilies")]
	public TEnum DealFamily;

}
