using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Flasks
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItemTypesKey;

	[FieldOffset(16)]
	public TString Name;

	[FieldOffset(24)]
	[ReferenceTable("FlaskType")]
	[EnumName("FlaskType")]
	public TEnum Type;

	[FieldOffset(28)]
	public int LifePerUse;

	[FieldOffset(32)]
	public int ManaPerUse;

	[FieldOffset(36)]
	public int RecoveryTime;

	[FieldOffset(40)]
	[ReferenceTable("BuffDefinitions")]
	public TRef BuffDefinitionsKey;

	[FieldOffset(56)]
	[ElementType(typeof(int))]
	public TArray BuffStatValues;

	[FieldOffset(72)]
	public int RecoveryTime2;

	[FieldOffset(76)]
	[ElementType(typeof(int))]
	public TArray BuffStatValues2;

}
