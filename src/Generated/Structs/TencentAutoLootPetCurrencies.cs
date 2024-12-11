using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TencentAutoLootPetCurrencies
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItemTypesKey;

	[FieldOffset(16)]
	public TBool Unk001;

	[FieldOffset(17)]
	[ElementType(typeof(int))]
	public TArray Unk002;

}
