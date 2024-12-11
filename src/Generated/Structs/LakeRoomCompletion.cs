using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LakeRoomCompletion
{
	[FieldOffset(0)]
	[ReferenceTable("LakeRooms")]
	public TRef Room;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	public int Unk002;

	[FieldOffset(24)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray Achievements;

	[FieldOffset(40)]
	[ElementType(typeof(int))]
	public TArray Unk004;

	[FieldOffset(56)]
	[ElementType(typeof(int))]
	public TArray Unk005;

	[FieldOffset(72)]
	public int Unk006;

}
