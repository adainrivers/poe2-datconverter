using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MicrotransactionPortalVariations
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItemTypesKey;

	[FieldOffset(16)]
	public int Id;

	[FieldOffset(20)]
	public TString AOFile;

	[FieldOffset(28)]
	public TString MapAOFile;

	[FieldOffset(36)]
	public float Unk004;

	[FieldOffset(40)]
	[ReferenceTable("MiscObjects")]
	public TRef MiscObject;

	[FieldOffset(56)]
	public TString PortalEffect;

	[FieldOffset(64)]
	public float Unk007;

	[FieldOffset(68)]
	public TString Unk008;

	[FieldOffset(76)]
	public TString PortalEffectLarge;

	[FieldOffset(84)]
	public int Unk010;

	[FieldOffset(88)]
	public int Unk011;

	[FieldOffset(92)]
	public TString Script;

}
