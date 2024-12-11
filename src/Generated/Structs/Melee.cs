using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Melee
{
	[FieldOffset(0)]
	[ReferenceTable("ActiveSkills")]
	public TRef ActiveSkill;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	[ReferenceTable("MiscAnimated")]
	public TRef MiscAnimated;

	[FieldOffset(36)]
	[ReferenceTable("MeleeTrails")]
	public TRef MeleeTrailsKey1;

	[FieldOffset(52)]
	[ReferenceTable("MeleeTrails")]
	public TRef MeleeTrailsKey2;

	[FieldOffset(68)]
	[ReferenceTable("MeleeTrails")]
	public TRef MeleeTrailsKey3;

	[FieldOffset(84)]
	[ReferenceTable("MeleeTrails")]
	public TRef MeleeTrailsKey4;

	[FieldOffset(100)]
	[ReferenceTable("MeleeTrails")]
	public TRef MeleeTrailsKey5;

	[FieldOffset(116)]
	[ReferenceTable("MeleeTrails")]
	public TRef MeleeTrailsKey6;

	[FieldOffset(132)]
	[ReferenceTable("MeleeTrails")]
	public TRef MeleeTrailsKey7;

	[FieldOffset(148)]
	public bool Unk010;

	[FieldOffset(149)]
	public TString SurgeEffect_EPKFile;

	[FieldOffset(157)]
	public TString Unk012;

	[FieldOffset(165)]
	public TString Unk013;

}
