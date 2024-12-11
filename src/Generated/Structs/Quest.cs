using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Quest
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int Act;

	[FieldOffset(12)]
	public TString Name;

	[FieldOffset(20)]
	public TString Icon_DDSFile;

	[FieldOffset(28)]
	public int QuestId;

	[FieldOffset(32)]
	public bool Unk005;

	[FieldOffset(33)]
	[ReferenceTable("QuestType")]
	public TRef Type;

	[FieldOffset(49)]
	[ElementType(typeof(int))]
	public TArray Unk007;

	[FieldOffset(65)]
	public int Unk008;

	[FieldOffset(69)]
	[ReferenceTable("QuestTrackerGroup")]
	public TRef TrackerGroup;

	[FieldOffset(85)]
	public bool Unk010;

	[FieldOffset(86)]
	public TRef Unk011;

}
