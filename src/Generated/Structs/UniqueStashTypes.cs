using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct UniqueStashTypes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int Order;

	[FieldOffset(12)]
	public int Width;

	[FieldOffset(16)]
	public int Height;

	[FieldOffset(20)]
	public int TotalCount;

	[FieldOffset(24)]
	public int Unk005;

	[FieldOffset(28)]
	public TString Name;

	[FieldOffset(36)]
	public int StandardCount;

	[FieldOffset(40)]
	public TString Image;

	[FieldOffset(48)]
	public int ChallengeLeagueCount;

	[FieldOffset(52)]
	public bool IsDisabled;

}
