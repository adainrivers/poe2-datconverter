using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BetrayalChoiceActions
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("BetrayalChoices")]
	public TRef BetrayalChoicesKey;

	[FieldOffset(24)]
	[ReferenceTable("ClientStrings")]
	public TRef ClientStringsKey;

}
