using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Projectiles
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ElementType(typeof(TString))]
	public TArray AOFiles;

	[FieldOffset(24)]
	[ElementType(typeof(TString))]
	public TArray LoopAnimationIds;

	[FieldOffset(40)]
	[ElementType(typeof(TString))]
	public TArray ImpactAnimationIds;

	[FieldOffset(56)]
	public int ProjectileSpeed;

	[FieldOffset(60)]
	public bool Unk005;

	[FieldOffset(61)]
	public int Unk006;

	[FieldOffset(65)]
	public bool Unk007;

	[FieldOffset(66)]
	public bool Unk008;

	[FieldOffset(67)]
	public TString InheritsFrom;

	[FieldOffset(75)]
	public int Unk010;

	[FieldOffset(79)]
	public TRef Unk011;

	[FieldOffset(95)]
	public int Unk012;

	[FieldOffset(99)]
	public bool Unk013;

	[FieldOffset(100)]
	public bool Unk014;

	[FieldOffset(101)]
	[ElementType(typeof(TString))]
	public TArray Stuck_AOFile;

	[FieldOffset(117)]
	public TString Bounce_AOFile;

	[FieldOffset(125)]
	public int Unk017;

	[FieldOffset(129)]
	public int Unk018;

	[FieldOffset(133)]
	public int Unk019;

	[FieldOffset(137)]
	public int Unk020;

	[FieldOffset(141)]
	public TRef Unk021;

	[FieldOffset(157)]
	public TRef Unk022;

	[FieldOffset(173)]
	public int Unk023;

	[FieldOffset(177)]
	public int Unk024;

	[FieldOffset(181)]
	public int Unk025;

	[FieldOffset(185)]
	public int Unk026;

	[FieldOffset(189)]
	public int Unk027;

	[FieldOffset(193)]
	[ElementType(typeof(TString))]
	public TArray Unk028;

	[FieldOffset(209)]
	public bool Unk029;

	[FieldOffset(210)]
	[ElementType(typeof(int))]
	public TArray Unk030;

	[FieldOffset(226)]
	[ReferenceTable("Projectiles")]
	public TRef Unk031;

}
