using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AchievementSetRewards
{
	[FieldOffset(0)]
	[ReferenceTable("AchievementSetsDisplay")]
	public int SetId;

	[FieldOffset(4)]
	public int AchievementsRequired;

	[FieldOffset(8)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TRef))]
	public TArray Rewards;

	[FieldOffset(24)]
	public int TotemPieceEveryNAchievements;

	[FieldOffset(28)]
	public TString Message;

	[FieldOffset(36)]
	public TString NotificationIcon;

	[FieldOffset(44)]
	public TString HideoutName;

	[FieldOffset(52)]
	public TString Id;

}
