using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SkillWeaponEffects
{
	[FieldOffset(0)]
	public TString Unk000;

	[FieldOffset(8)]
	public TRef Unk001;

	[FieldOffset(24)]
	public TBool Unk002;

	[FieldOffset(25)]
	public int Unk003;

	[FieldOffset(29)]
	public int Unk004;

}
