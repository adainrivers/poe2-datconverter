namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MiscObjects
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference EffectVirtualPath;

	[FieldOffset(16)]
	[ReferenceTable("PreloadGroups")]
	[ElementType(typeof(TableReference))]
	public ArrayReference PreloadGroupsKeys;

	[FieldOffset(32)]
	public int Unk003;

	[FieldOffset(36)]
	public int Unk004;

	[FieldOffset(40)]
	public int Unk005;

}
