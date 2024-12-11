using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Acts
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int Part;

	[FieldOffset(12)]
	public TString Unk002;

	[FieldOffset(20)]
	public int Unk003;

	[FieldOffset(24)]
	public int ActNumber;

	[FieldOffset(28)]
	public TString WorldPanelImage;

	[FieldOffset(36)]
	public TString WorldPanelImageEpilogue;

	[FieldOffset(44)]
	public int Unk007;

	[FieldOffset(48)]
	public TBool IsPostGame;

	[FieldOffset(49)]
	public int Unk009;

	[FieldOffset(53)]
	[ReferenceTable("QuestFlags")]
	[ElementType(typeof(TRef))]
	public TArray Unk010;

}
