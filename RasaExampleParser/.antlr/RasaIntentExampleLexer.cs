//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from RasaIntentExample.g4 by ANTLR 4.13.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.0")]
[System.CLSCompliant(false)]
public partial class RasaIntentExampleLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, WORD=4;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "WORD", "Letter"
	};


	public RasaIntentExampleLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public RasaIntentExampleLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'['", "']('", "')'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, "WORD"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "RasaIntentExample.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static RasaIntentExampleLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,4,35,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,1,0,1,0,1,1,1,1,
		1,1,1,2,1,2,1,3,4,3,20,8,3,11,3,12,3,21,1,4,1,4,1,4,1,4,1,4,4,4,29,8,4,
		11,4,12,4,30,1,4,3,4,34,8,4,0,0,5,1,1,3,2,5,3,7,4,9,0,1,0,6,6,0,36,36,
		45,45,48,57,65,90,95,95,97,122,2,0,0,127,55296,56319,1,0,55296,56319,1,
		0,56320,57343,3,0,9,10,13,13,32,32,6,0,34,35,37,38,44,44,46,46,58,59,63,
		63,39,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,1,11,1,0,0,0,3,13,
		1,0,0,0,5,16,1,0,0,0,7,19,1,0,0,0,9,33,1,0,0,0,11,12,5,91,0,0,12,2,1,0,
		0,0,13,14,5,93,0,0,14,15,5,40,0,0,15,4,1,0,0,0,16,17,5,41,0,0,17,6,1,0,
		0,0,18,20,3,9,4,0,19,18,1,0,0,0,20,21,1,0,0,0,21,19,1,0,0,0,21,22,1,0,
		0,0,22,8,1,0,0,0,23,34,7,0,0,0,24,34,8,1,0,0,25,26,7,2,0,0,26,34,7,3,0,
		0,27,29,7,4,0,0,28,27,1,0,0,0,29,30,1,0,0,0,30,28,1,0,0,0,30,31,1,0,0,
		0,31,34,1,0,0,0,32,34,7,5,0,0,33,23,1,0,0,0,33,24,1,0,0,0,33,25,1,0,0,
		0,33,28,1,0,0,0,33,32,1,0,0,0,34,10,1,0,0,0,4,0,21,30,33,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
