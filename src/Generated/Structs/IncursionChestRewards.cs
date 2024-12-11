using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct IncursionChestRewards
{
	[FieldOffset(0)]
	[ReferenceTable("IncursionRooms")]
	public TRef IncursionRoomsKey;

	[FieldOffset(16)]
	[ReferenceTable("IncursionChests")]
	[ElementType(typeof(TRef))]
	public TArray IncursionChestsKeys;

	[FieldOffset(32)]
	public TString ChestMarkerMetadata;

	[FieldOffset(40)]
	public int Unk003;

	[FieldOffset(44)]
	public int Unk004;

	[FieldOffset(48)]
	public int Unk005;

	[FieldOffset(52)]
	public int Unk006;

	[FieldOffset(56)]
	public int Unk007;

	[FieldOffset(60)]
	public int Unk008;

	[FieldOffset(64)]
	public int Unk009;

	[FieldOffset(68)]
	public int Unk010;

	[FieldOffset(72)]
	public int Unk011;

}
