using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SanctumFloors
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("WorldAreas")]
	public TRef Area;

	[FieldOffset(24)]
	[ReferenceTable("ClientStrings")]
	public TRef Title;

	[FieldOffset(40)]
	public TString RoomIcon;

	[FieldOffset(48)]
	public TString BossIcon;

	[FieldOffset(56)]
	public TString Description;

	[FieldOffset(64)]
	[ReferenceTable("ClientStrings")]
	public TRef Summary;

	[FieldOffset(80)]
	[ReferenceTable("BaseItemTypes")]
	public TRef Itemised;

}
