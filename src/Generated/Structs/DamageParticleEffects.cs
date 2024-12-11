using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DamageParticleEffects
{
	[FieldOffset(0)]
	[ReferenceTable("DamageParticleEffectTypes")]
	[EnumName("DamageParticleEffectTypes")]
	public TEnum DamageParticleEffectTypes;

	[FieldOffset(4)]
	public int Variation;

	[FieldOffset(8)]
	public TString PETFile;

	[FieldOffset(16)]
	[ReferenceTable("ImpactSoundData")]
	public TRef ImpactSoundData1;

	[FieldOffset(32)]
	[ReferenceTable("ImpactSoundData")]
	public TRef ImpactSoundData2;

	[FieldOffset(48)]
	public int Unk005;

}
