using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BetrayalUpgrades
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Name;

	[FieldOffset(16)]
	public TString Description;

	[FieldOffset(24)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TRef))]
	public TArray ModsKey;

	[FieldOffset(40)]
	public TString ArtFile;

	[FieldOffset(48)]
	public int BetrayalUpgradeSlotsKey;

	[FieldOffset(52)]
	[ElementType(typeof(int))]
	public TArray Unk006;

	[FieldOffset(68)]
	[ReferenceTable("ItemVisualIdentity")]
	public TRef ItemVisualIdentityKey0;

	[FieldOffset(84)]
	[ReferenceTable("ItemVisualIdentity")]
	public TRef ItemVisualIdentityKey1;

	[FieldOffset(100)]
	[ReferenceTable("GrantedEffects")]
	public TRef GrantedEffectsKey;

	[FieldOffset(116)]
	public int Unk010;

	[FieldOffset(120)]
	[ReferenceTable("ItemClasses")]
	public TRef ItemClassesKey;

}
