using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemVisualEffect
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString DaggerEPKFile;

	[FieldOffset(16)]
	public TString BowEPKFile;

	[FieldOffset(24)]
	public TString OneHandedMaceEPKFile;

	[FieldOffset(32)]
	public TString OneHandedSwordEPKFile;

	[FieldOffset(40)]
	public TString Unk005;

	[FieldOffset(48)]
	public TString TwoHandedSwordEPKFile;

	[FieldOffset(56)]
	public TString TwoHandedStaffEPKFile;

	[FieldOffset(64)]
	public short HASH16;

	[FieldOffset(66)]
	public TString TwoHandedMaceEPKFile;

	[FieldOffset(74)]
	public TString OneHandedAxeEPKFile;

	[FieldOffset(82)]
	public TString TwoHandedAxeEPKFile;

	[FieldOffset(90)]
	public TString ClawEPKFile;

	[FieldOffset(98)]
	public TString PETFile;

	[FieldOffset(106)]
	[ElementType(typeof(TString))]
	public TArray Shield;

	[FieldOffset(122)]
	public bool Unk015;

}
