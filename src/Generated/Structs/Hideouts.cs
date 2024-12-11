using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Hideouts
{
	[FieldOffset(0)]
	[ReferenceTable("WorldAreas")]
	public TRef HideoutArea;

	[FieldOffset(16)]
	public short HASH16;

	[FieldOffset(18)]
	public TString HideoutFile;

	[FieldOffset(26)]
	[ReferenceTable("WorldAreas")]
	[ElementType(typeof(TRef))]
	public TArray SpawnAreas;

	[FieldOffset(42)]
	[ReferenceTable("WorldAreas")]
	public TRef ClaimSideArea;

	[FieldOffset(58)]
	public TString HideoutImage;

	[FieldOffset(66)]
	public bool IsEnabled;

	[FieldOffset(67)]
	public int Weight;

	[FieldOffset(71)]
	[ReferenceTable("HideoutRarity")]
	public TRef Rarity;

	[FieldOffset(87)]
	public bool NotActsArea;

	[FieldOffset(88)]
	public TString Name;

	[FieldOffset(96)]
	[ElementType(typeof(int))]
	public TArray Unk011;

	[FieldOffset(112)]
	public bool Unk012;

	[FieldOffset(113)]
	public bool Unk013;

	[FieldOffset(114)]
	public bool Unk014;

	[FieldOffset(115)]
	public bool Unk015;

	[FieldOffset(116)]
	public TString ErrorMessage;

}
