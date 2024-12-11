using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ExpeditionFactions
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Name;

	[FieldOffset(16)]
	public TString FactionFlag;

	[FieldOffset(24)]
	public int Unk003;

	[FieldOffset(28)]
	public TString FactionIcon;

	[FieldOffset(36)]
	[ReferenceTable("MonsterVarieties")]
	public TRef MonsterVarieties;

	[FieldOffset(52)]
	[ReferenceTable("NPCTextAudio")]
	public TRef Progress1;

	[FieldOffset(68)]
	[ReferenceTable("NPCTextAudio")]
	public TRef Progress2Vaal;

	[FieldOffset(84)]
	[ReferenceTable("NPCTextAudio")]
	public TRef Progress3Final;

	[FieldOffset(100)]
	[ReferenceTable("Tags")]
	public TRef Tags;

}
