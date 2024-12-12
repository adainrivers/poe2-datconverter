namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BlightEncounterWaves
{
	[FieldOffset(0)]
	public StringReference MonsterSpawnerId;

	[FieldOffset(8)]
	[ReferenceTable("BlightEncounterTypes")]
	public TableReference EncounterType;

	[FieldOffset(24)]
	public int Unk002;

	[FieldOffset(28)]
	public int Unk003;

	[FieldOffset(32)]
	public int Unk004;

	[FieldOffset(36)]
	public int Wave;

}
