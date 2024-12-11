using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct VillageUpgradeCategories
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString ScriptArgs;

	[FieldOffset(16)]
	public TString Name;

	[FieldOffset(24)]
	public TString Icon;

	[FieldOffset(32)]
	public TString Text;

	[FieldOffset(40)]
	public TRef Unk005;

}
