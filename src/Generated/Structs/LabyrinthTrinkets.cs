using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LabyrinthTrinkets
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItemTypesKey;

	[FieldOffset(16)]
	[ReferenceTable("LabyrinthSecrets")]
	[ElementType(typeof(TRef))]
	public TArray LabyrinthSecretsKey;

	[FieldOffset(32)]
	[ReferenceTable("BuffDefinitions")]
	public TRef Buff_BuffDefinitionsKey;

	[FieldOffset(48)]
	[ElementType(typeof(int))]
	public TArray Buff_StatValues;

}
