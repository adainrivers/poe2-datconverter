using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HideoutNPCs
{
	[FieldOffset(0)]
	[ReferenceTable("NPCs")]
	public TRef Hideout_NPCsKey;

	[FieldOffset(16)]
	[ReferenceTable("NPCs")]
	[ElementType(typeof(TRef))]
	public TArray Regular_NPCsKeys;

	[FieldOffset(32)]
	[ReferenceTable("HideoutDoodads")]
	public TRef HideoutDoodadsKey;

	[FieldOffset(48)]
	public int NPCMasterKey;

	[FieldOffset(52)]
	public TRef Unk004;

	[FieldOffset(68)]
	public TRef Unk005;

	[FieldOffset(84)]
	public int Unk006;

	[FieldOffset(88)]
	public TRef Unk007;

	[FieldOffset(104)]
	public int Unk008;

	[FieldOffset(108)]
	public bool Unk009;

	[FieldOffset(109)]
	public TRef Unk010;

}
