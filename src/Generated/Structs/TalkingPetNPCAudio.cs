namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TalkingPetNPCAudio
{
	[FieldOffset(0)]
	[ReferenceTable("TalkingPetAudioEvents")]
	public TableReference Unk000;

	[FieldOffset(16)]
	[ReferenceTable("TalkingPets")]
	public TableReference Unk001;

	[FieldOffset(32)]
	[ElementType(typeof(int))]
	public ArrayReference Unk002;

	[FieldOffset(48)]
	public StringReference Unk003;

	[FieldOffset(56)]
	public TBool Unk004;

}
