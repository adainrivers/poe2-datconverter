using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LabyrinthSectionLayout
{
	[FieldOffset(0)]
	[ReferenceTable("LabyrinthSection")]
	public TRef LabyrinthSectionKey;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	[ReferenceTable("LabyrinthSectionLayout")]
	[ElementType(typeof(TRef))]
	public TArray LabyrinthSectionLayoutKeys;

	[FieldOffset(36)]
	[ReferenceTable("LabyrinthSecrets")]
	public TRef LabyrinthSecretsKey0;

	[FieldOffset(52)]
	[ReferenceTable("LabyrinthSecrets")]
	public TRef LabyrinthSecretsKey1;

	[FieldOffset(68)]
	[ReferenceTable("LabyrinthAreas")]
	public TRef LabyrinthAreasKey;

	[FieldOffset(84)]
	public float Float0;

	[FieldOffset(88)]
	public float Float1;

	[FieldOffset(92)]
	[ReferenceTable("LabyrinthNodeOverrides")]
	[ElementType(typeof(TRef))]
	public TArray LabyrinthNodeOverridesKeys;

}
