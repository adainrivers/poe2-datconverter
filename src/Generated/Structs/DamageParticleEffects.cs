namespace PoE2Converter.Generated.Structs;

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
	public StringReference PETFile;

	[FieldOffset(16)]
	[ReferenceTable("ImpactSoundData")]
	public TableReference ImpactSoundData1;

	[FieldOffset(32)]
	[ReferenceTable("ImpactSoundData")]
	public TableReference ImpactSoundData2;

	[FieldOffset(48)]
	public int Unk005;

}
