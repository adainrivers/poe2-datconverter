using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NPCDialogueStyles
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString HeaderBaseFile;

	[FieldOffset(16)]
	public TString ButtomFile;

	[FieldOffset(24)]
	[ElementType(typeof(TString))]
	public TArray BannerFiles;

	[FieldOffset(40)]
	[ElementType(typeof(TString))]
	public TArray HeaderFiles;

	[FieldOffset(56)]
	public int Unk005;

	[FieldOffset(60)]
	public int Unk006;

	[FieldOffset(64)]
	public int Unk007;

	[FieldOffset(68)]
	public int Unk008;

	[FieldOffset(72)]
	public int Unk009;

	[FieldOffset(76)]
	[ElementType(typeof(int))]
	public TArray Unk010;

	[FieldOffset(92)]
	[ReferenceTable("NPCDialogueStyles")]
	public TRef Unk011;

	[FieldOffset(100)]
	public TString Unk012;

	[FieldOffset(108)]
	[ElementType(typeof(int))]
	public TArray Unk013;

	[FieldOffset(124)]
	[ElementType(typeof(int))]
	public TArray Unk014;

	[FieldOffset(140)]
	public int Unk015;

	[FieldOffset(144)]
	public int Unk016;

	[FieldOffset(148)]
	public float Unk017;

	[FieldOffset(152)]
	public TString Unk018;

	[FieldOffset(160)]
	public TString Unk019;

	[FieldOffset(168)]
	public int Unk020;

	[FieldOffset(172)]
	public int Unk021;

}
