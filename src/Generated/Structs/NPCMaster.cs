using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NPCMaster
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TBool Unk001;

	[FieldOffset(9)]
	public TBool Unk002;

	[FieldOffset(10)]
	[ReferenceTable("Mods")]
	public TRef Signature_ModsKey;

	[FieldOffset(26)]
	public TBool Unk004;

	[FieldOffset(27)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TRef))]
	public TArray SpawnWeight_TagsKeys;

	[FieldOffset(43)]
	[ElementType(typeof(int))]
	public TArray SpawnWeight_Values;

	[FieldOffset(59)]
	public TRef Unk007;

	[FieldOffset(75)]
	public int Unk008;

	[FieldOffset(79)]
	public TString AreaDescription;

	[FieldOffset(87)]
	public TRef Unk010;

	[FieldOffset(103)]
	public int Unk011;

	[FieldOffset(107)]
	[ReferenceTable("Stats")]
	public TRef Unk012;

	[FieldOffset(123)]
	public TBool HasAreaMissions;

	[FieldOffset(124)]
	[ElementType(typeof(TRef))]
	public TArray Unk014;

	[FieldOffset(140)]
	[ElementType(typeof(TRef))]
	public TArray Unk015;

	[FieldOffset(156)]
	public TRef Unk016;

	[FieldOffset(172)]
	[ElementType(typeof(TRef))]
	public TArray Unk017;

	[FieldOffset(188)]
	public TRef Unk018;

}
