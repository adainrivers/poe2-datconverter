using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SanctumRooms
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString ArmFile;

	[FieldOffset(16)]
	[ReferenceTable("SanctumRoomTypes")]
	public TRef RoomType;

	[FieldOffset(32)]
	public TString Script;

	[FieldOffset(40)]
	[ReferenceTable("SanctumFloors")]
	public TRef Floor;

	[FieldOffset(56)]
	[ReferenceTable("WorldAreas")]
	public TRef Area;

}
