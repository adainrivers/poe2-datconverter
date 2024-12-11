using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AncestralTrialTribes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TRef Unk001;

	[FieldOffset(24)]
	public TString Portrait;

	[FieldOffset(32)]
	public TString TribeIcon;

	[FieldOffset(40)]
	public TString TribeName;

	[FieldOffset(48)]
	public TString FavourTracker;

	[FieldOffset(56)]
	[ElementType(typeof(TRef))]
	public TArray Unk006;

	[FieldOffset(72)]
	public TString Name;

	[FieldOffset(80)]
	public TRef Unk008;

	[FieldOffset(96)]
	public TRef Unk009;

	[FieldOffset(112)]
	public TRef Unk010;

	[FieldOffset(128)]
	public TRef Unk011;

	[FieldOffset(144)]
	[ElementType(typeof(TRef))]
	public TArray Unk012;

	[FieldOffset(160)]
	public TRef Unk013;

	[FieldOffset(176)]
	[ElementType(typeof(TRef))]
	public TArray Unk014;

	[FieldOffset(192)]
	public int Unk015;

	[FieldOffset(196)]
	public int Unk016;

	[FieldOffset(200)]
	public int Unk017;

	[FieldOffset(204)]
	public int Unk018;

	[FieldOffset(208)]
	public TRef Unk019;

}
