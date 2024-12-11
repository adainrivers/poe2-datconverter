using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LabyrinthSecretEffects
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("MonsterVarieties")]
	public TRef MonsterVarietiesKey;

	[FieldOffset(24)]
	[ReferenceTable("BuffDefinitions")]
	public TRef Buff_BuffDefinitionsKey;

	[FieldOffset(40)]
	[ElementType(typeof(int))]
	public TArray Buff_StatValues;

	[FieldOffset(56)]
	public TString OTFile;

	[FieldOffset(64)]
	[ElementType(typeof(int))]
	public TArray Unk005;

}
