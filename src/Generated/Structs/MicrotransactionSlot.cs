using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MicrotransactionSlot
{
	[FieldOffset(0)]
	[ReferenceTable("MicrotransactionSlotId")]
	[EnumName("MicrotransactionSlotId")]
	public TEnum Id;

	[FieldOffset(4)]
	public TRef Unk001;

	[FieldOffset(20)]
	public TString Name;

	[FieldOffset(28)]
	public TRef Unk003;

	[FieldOffset(44)]
	public int Unk004;

	[FieldOffset(48)]
	public TBool Unk005;

	[FieldOffset(49)]
	public int Unk006;

	[FieldOffset(53)]
	public int Unk007;

	[FieldOffset(57)]
	public TBool Unk008;

}
