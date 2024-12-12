namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SigilDisplay
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("Stats")]
	public TableReference Active_StatsKey;

	[FieldOffset(24)]
	[ReferenceTable("Stats")]
	public TableReference Inactive_StatsKey;

	[FieldOffset(40)]
	public StringReference DDSFile;

	[FieldOffset(48)]
	public StringReference Inactive_ArtFile;

	[FieldOffset(56)]
	public StringReference Active_ArtFile;

	[FieldOffset(64)]
	public StringReference Frame_ArtFile;

}
