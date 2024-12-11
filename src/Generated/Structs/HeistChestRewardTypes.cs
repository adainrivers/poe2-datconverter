using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistChestRewardTypes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Art;

	[FieldOffset(16)]
	public TString RewardTypeName;

	[FieldOffset(24)]
	[ReferenceTable("HeistChestRewardTypes")]
	public TRef Unk003;

	[FieldOffset(32)]
	public TString RewardRoomName;

	[FieldOffset(40)]
	public int MinLevel;

	[FieldOffset(44)]
	public int MaxLevel;

	[FieldOffset(48)]
	public int Weight;

	[FieldOffset(52)]
	public TString RewardRoomName2;

	[FieldOffset(60)]
	[ReferenceTable("HeistJobs")]
	[ElementType(typeof(TRef))]
	public TArray HeistJobsKey;

	[FieldOffset(76)]
	public int Unk010;

	[FieldOffset(80)]
	public int Unk011;

}
