using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AtlasPrimordialBossOptions
{
	[FieldOffset(0)]
	public int Unk000;

	[FieldOffset(4)]
	public int Unk001;

	[FieldOffset(8)]
	public TString DefaultIcon;

	[FieldOffset(16)]
	public TString HoverIcon;

	[FieldOffset(24)]
	public TString HighlightIcon;

	[FieldOffset(32)]
	public TString EmptyIcon;

	[FieldOffset(40)]
	[ReferenceTable("ClientStrings")]
	public TRef Description;

	[FieldOffset(56)]
	[ReferenceTable("ClientStrings")]
	public TRef DescriptionActive;

	[FieldOffset(72)]
	public TString ProgressTracker;

	[FieldOffset(80)]
	public TString ProgressTrackerFill;

	[FieldOffset(88)]
	public TString Name;

	[FieldOffset(96)]
	public TString MapDeviceTrackerFill;

}
