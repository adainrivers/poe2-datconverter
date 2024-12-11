using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AncestralTrialPositionType
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString PlayerTotemIcon;

	[FieldOffset(16)]
	public TString Name;

	[FieldOffset(24)]
	public TString EnemyTotemIcon;

	[FieldOffset(32)]
	public TString PlayerTotemSmallIcon;

	[FieldOffset(40)]
	public TString EnemyTotemSmallIcon;

}
