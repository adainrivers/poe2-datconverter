using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PassiveTreeExpansionJewels
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItemTypesKey;

	[FieldOffset(16)]
	[ReferenceTable("PassiveTreeExpansionJewelSizes")]
	public TRef PassiveTreeExpansionJewelSizesKey;

	[FieldOffset(32)]
	public int MinNodes;

	[FieldOffset(36)]
	public int MaxNodes;

	[FieldOffset(40)]
	[ElementType(typeof(int))]
	public TArray SmallIndices;

	[FieldOffset(56)]
	[ElementType(typeof(int))]
	public TArray NotableIndices;

	[FieldOffset(72)]
	[ElementType(typeof(int))]
	public TArray SocketIndices;

	[FieldOffset(88)]
	public int TotalIndices;

}
