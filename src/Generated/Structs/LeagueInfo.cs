using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LeagueInfo
{
	[FieldOffset(0)]
	[ReferenceTable("LeagueInfoPanelVersions")]
	public TRef PanelVersion;

	[FieldOffset(16)]
	public TString PanelId;

	[FieldOffset(24)]
	public TString PanelImage;

	[FieldOffset(32)]
	public TString HeaderImage;

	[FieldOffset(40)]
	[ElementType(typeof(TString))]
	public TArray Screenshots;

	[FieldOffset(56)]
	public TString Description;

	[FieldOffset(64)]
	public bool Unk006;

	[FieldOffset(65)]
	public TString TrailerVideoLink;

	[FieldOffset(73)]
	public TString BackgroundImage;

	[FieldOffset(81)]
	public bool Unk009;

	[FieldOffset(82)]
	public bool Unk010;

	[FieldOffset(83)]
	[ElementType(typeof(TString))]
	public TArray PanelItems;

	[FieldOffset(99)]
	public TString Unk012;

}
