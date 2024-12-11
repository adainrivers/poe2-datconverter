using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NPCs
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Name;

	[FieldOffset(16)]
	public TString Metadata;

	[FieldOffset(24)]
	public TRef Unk003;

	[FieldOffset(40)]
	[ReferenceTable("NPCMaster")]
	public TRef NPCMasterKey;

	[FieldOffset(56)]
	public TString ShortName;

	[FieldOffset(64)]
	public int Unk006;

	[FieldOffset(68)]
	[ReferenceTable("NPCAudio")]
	[ElementType(typeof(TRef))]
	public TArray NPCAudios1;

	[FieldOffset(84)]
	[ReferenceTable("NPCAudio")]
	[ElementType(typeof(TRef))]
	public TArray NPCAudios2;

	[FieldOffset(100)]
	public short HASH16;

	[FieldOffset(102)]
	[ReferenceTable("NPCs")]
	public TRef Unk010;

	[FieldOffset(110)]
	[ReferenceTable("NPCPortraits")]
	public TRef Portrait;

	[FieldOffset(126)]
	[ReferenceTable("NPCDialogueStyles")]
	public TRef DialogueStyle;

	[FieldOffset(142)]
	public bool Unk013;

	[FieldOffset(143)]
	public TRef Unk014;

	[FieldOffset(159)]
	public TString Gender;

	[FieldOffset(167)]
	public bool Unk016;

}
