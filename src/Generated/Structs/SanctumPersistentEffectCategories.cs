using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SanctumPersistentEffectCategories
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Frame;

	[FieldOffset(16)]
	public TString Popup;

	[FieldOffset(24)]
	public TString Glow;

	[FieldOffset(32)]
	public bool Curse;

	[FieldOffset(33)]
	public bool Boon;

	[FieldOffset(34)]
	public TString Icon;

	[FieldOffset(42)]
	public TString Name;

	[FieldOffset(50)]
	public bool Deferral;

}
