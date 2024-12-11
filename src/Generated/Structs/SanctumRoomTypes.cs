using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SanctumRoomTypes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TBool Unk001;

	[FieldOffset(9)]
	public TBool Unk002;

	[FieldOffset(10)]
	public TRef Unk003;

	[FieldOffset(26)]
	public TRef Unk004;

	[FieldOffset(42)]
	public TBool Unk005;

	[FieldOffset(43)]
	public TString Icon;

	[FieldOffset(51)]
	public TBool Unk007;

	[FieldOffset(52)]
	public TString Description;

	[FieldOffset(60)]
	[ElementType(typeof(TString))]
	public TArray Unk009;

	[FieldOffset(76)]
	[ReferenceTable("SanctumRooms")]
	[ElementType(typeof(TRef))]
	public TArray Rooms;

	[FieldOffset(92)]
	public TString Unk011;

	[FieldOffset(100)]
	public TBool Unk012;

}
