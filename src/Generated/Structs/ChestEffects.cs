namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ChestEffects
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Normal_EPKFile;

	[FieldOffset(16)]
	public StringReference Normal_Closed_AOFile;

	[FieldOffset(24)]
	public StringReference Normal_Open_AOFile;

	[FieldOffset(32)]
	public StringReference Magic_EPKFile;

	[FieldOffset(40)]
	public StringReference Unique_EPKFile;

	[FieldOffset(48)]
	public StringReference Rare_EPKFile;

	[FieldOffset(56)]
	public StringReference Magic_Closed_AOFile;

	[FieldOffset(64)]
	public StringReference Unique_Closed_AOFile;

	[FieldOffset(72)]
	public StringReference Rare_Closed_AOFile;

	[FieldOffset(80)]
	public StringReference Magic_Open_AOFile;

	[FieldOffset(88)]
	public StringReference Unique_Open_AOFile;

	[FieldOffset(96)]
	public StringReference Rare_Open_AOFile;

}
