using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemFrameType
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TBool Unk001;

	[FieldOffset(9)]
	public TBool DoubleLine;

	[FieldOffset(10)]
	public TString HeaderSingle;

	[FieldOffset(18)]
	public TString HeaderDouble;

	[FieldOffset(26)]
	public TString HardmodeHeaderSingle;

	[FieldOffset(34)]
	public TString HardmodeHeaderDouble;

	[FieldOffset(42)]
	[ElementType(typeof(int))]
	public TArray Color;

	[FieldOffset(58)]
	public TString Separator;

	[FieldOffset(66)]
	public TBool Unk009;

	[FieldOffset(67)]
	[ReferenceTable("Rarity")]
	public TRef Rarity;

	[FieldOffset(83)]
	[ReferenceTable("ClientStrings")]
	public TRef DisplayString;

	[FieldOffset(99)]
	public TString ColorMarkup;

	[FieldOffset(107)]
	public int Unk013;

}
