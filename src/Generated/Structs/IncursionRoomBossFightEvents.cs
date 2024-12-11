using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct IncursionRoomBossFightEvents
{
	[FieldOffset(0)]
	[ReferenceTable("IncursionRooms")]
	public TRef Room;

	[FieldOffset(16)]
	public TString Unk001;

	[FieldOffset(24)]
	public TString Unk002;

	[FieldOffset(32)]
	public TString Unk003;

	[FieldOffset(40)]
	public TString Unk004;

	[FieldOffset(48)]
	public TString Unk005;

	[FieldOffset(56)]
	public TRef Unk006;

}
