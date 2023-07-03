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
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.0")]
[System.CLSCompliant(false)]
internal partial class RasaIntentExampleParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, WORD=4;
	public const int
		RULE_example = 0, RULE_text = 1, RULE_entityExample = 2, RULE_entityValue = 3, 
		RULE_entityName = 4;
	public static readonly string[] ruleNames = {
		"example", "text", "entityExample", "entityValue", "entityName"
	};

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

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static RasaIntentExampleParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public RasaIntentExampleParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public RasaIntentExampleParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class ExampleContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public TextContext[] text() {
			return GetRuleContexts<TextContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public TextContext text(int i) {
			return GetRuleContext<TextContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public EntityExampleContext[] entityExample() {
			return GetRuleContexts<EntityExampleContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public EntityExampleContext entityExample(int i) {
			return GetRuleContext<EntityExampleContext>(i);
		}
		public ExampleContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_example; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IRasaIntentExampleListener typedListener = listener as IRasaIntentExampleListener;
			if (typedListener != null) typedListener.EnterExample(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IRasaIntentExampleListener typedListener = listener as IRasaIntentExampleListener;
			if (typedListener != null) typedListener.ExitExample(this);
		}
	}

	[RuleVersion(0)]
	public ExampleContext example() {
		ExampleContext _localctx = new ExampleContext(Context, State);
		EnterRule(_localctx, 0, RULE_example);
		int _la;
		try {
			int _alt;
			State = 40;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case WORD:
				EnterOuterAlt(_localctx, 1);
				{
				State = 21;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				do {
					{
					{
					State = 11;
					ErrorHandler.Sync(this);
					_alt = 1;
					do {
						switch (_alt) {
						case 1:
							{
							{
							State = 10;
							text();
							}
							}
							break;
						default:
							throw new NoViableAltException(this);
						}
						State = 13;
						ErrorHandler.Sync(this);
						_alt = Interpreter.AdaptivePredict(TokenStream,0,Context);
					} while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER );
					State = 18;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					while (_la==T__0) {
						{
						{
						State = 15;
						entityExample();
						}
						}
						State = 20;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
					}
					}
					}
					State = 23;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				} while ( _la==WORD );
				}
				break;
			case T__0:
				EnterOuterAlt(_localctx, 2);
				{
				State = 36;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				do {
					{
					{
					State = 26;
					ErrorHandler.Sync(this);
					_alt = 1;
					do {
						switch (_alt) {
						case 1:
							{
							{
							State = 25;
							entityExample();
							}
							}
							break;
						default:
							throw new NoViableAltException(this);
						}
						State = 28;
						ErrorHandler.Sync(this);
						_alt = Interpreter.AdaptivePredict(TokenStream,3,Context);
					} while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER );
					State = 33;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					while (_la==WORD) {
						{
						{
						State = 30;
						text();
						}
						}
						State = 35;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
					}
					}
					}
					State = 38;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				} while ( _la==T__0 );
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TextContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] WORD() { return GetTokens(RasaIntentExampleParser.WORD); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WORD(int i) {
			return GetToken(RasaIntentExampleParser.WORD, i);
		}
		public TextContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_text; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IRasaIntentExampleListener typedListener = listener as IRasaIntentExampleListener;
			if (typedListener != null) typedListener.EnterText(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IRasaIntentExampleListener typedListener = listener as IRasaIntentExampleListener;
			if (typedListener != null) typedListener.ExitText(this);
		}
	}

	[RuleVersion(0)]
	public TextContext text() {
		TextContext _localctx = new TextContext(Context, State);
		EnterRule(_localctx, 2, RULE_text);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 43;
			ErrorHandler.Sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					State = 42;
					Match(WORD);
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 45;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,7,Context);
			} while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class EntityExampleContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public EntityValueContext entityValue() {
			return GetRuleContext<EntityValueContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public EntityNameContext entityName() {
			return GetRuleContext<EntityNameContext>(0);
		}
		public EntityExampleContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_entityExample; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IRasaIntentExampleListener typedListener = listener as IRasaIntentExampleListener;
			if (typedListener != null) typedListener.EnterEntityExample(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IRasaIntentExampleListener typedListener = listener as IRasaIntentExampleListener;
			if (typedListener != null) typedListener.ExitEntityExample(this);
		}
	}

	[RuleVersion(0)]
	public EntityExampleContext entityExample() {
		EntityExampleContext _localctx = new EntityExampleContext(Context, State);
		EnterRule(_localctx, 4, RULE_entityExample);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 47;
			Match(T__0);
			State = 48;
			entityValue();
			State = 49;
			Match(T__1);
			State = 50;
			entityName();
			State = 51;
			Match(T__2);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class EntityValueContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] WORD() { return GetTokens(RasaIntentExampleParser.WORD); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WORD(int i) {
			return GetToken(RasaIntentExampleParser.WORD, i);
		}
		public EntityValueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_entityValue; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IRasaIntentExampleListener typedListener = listener as IRasaIntentExampleListener;
			if (typedListener != null) typedListener.EnterEntityValue(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IRasaIntentExampleListener typedListener = listener as IRasaIntentExampleListener;
			if (typedListener != null) typedListener.ExitEntityValue(this);
		}
	}

	[RuleVersion(0)]
	public EntityValueContext entityValue() {
		EntityValueContext _localctx = new EntityValueContext(Context, State);
		EnterRule(_localctx, 6, RULE_entityValue);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 54;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 53;
				Match(WORD);
				}
				}
				State = 56;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==WORD );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class EntityNameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] WORD() { return GetTokens(RasaIntentExampleParser.WORD); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WORD(int i) {
			return GetToken(RasaIntentExampleParser.WORD, i);
		}
		public EntityNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_entityName; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IRasaIntentExampleListener typedListener = listener as IRasaIntentExampleListener;
			if (typedListener != null) typedListener.EnterEntityName(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IRasaIntentExampleListener typedListener = listener as IRasaIntentExampleListener;
			if (typedListener != null) typedListener.ExitEntityName(this);
		}
	}

	[RuleVersion(0)]
	public EntityNameContext entityName() {
		EntityNameContext _localctx = new EntityNameContext(Context, State);
		EnterRule(_localctx, 8, RULE_entityName);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 59;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 58;
				Match(WORD);
				}
				}
				State = 61;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==WORD );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static int[] _serializedATN = {
		4,1,4,64,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,1,0,4,0,12,8,0,11,0,12,
		0,13,1,0,5,0,17,8,0,10,0,12,0,20,9,0,4,0,22,8,0,11,0,12,0,23,1,0,4,0,27,
		8,0,11,0,12,0,28,1,0,5,0,32,8,0,10,0,12,0,35,9,0,4,0,37,8,0,11,0,12,0,
		38,3,0,41,8,0,1,1,4,1,44,8,1,11,1,12,1,45,1,2,1,2,1,2,1,2,1,2,1,2,1,3,
		4,3,55,8,3,11,3,12,3,56,1,4,4,4,60,8,4,11,4,12,4,61,1,4,0,0,5,0,2,4,6,
		8,0,0,68,0,40,1,0,0,0,2,43,1,0,0,0,4,47,1,0,0,0,6,54,1,0,0,0,8,59,1,0,
		0,0,10,12,3,2,1,0,11,10,1,0,0,0,12,13,1,0,0,0,13,11,1,0,0,0,13,14,1,0,
		0,0,14,18,1,0,0,0,15,17,3,4,2,0,16,15,1,0,0,0,17,20,1,0,0,0,18,16,1,0,
		0,0,18,19,1,0,0,0,19,22,1,0,0,0,20,18,1,0,0,0,21,11,1,0,0,0,22,23,1,0,
		0,0,23,21,1,0,0,0,23,24,1,0,0,0,24,41,1,0,0,0,25,27,3,4,2,0,26,25,1,0,
		0,0,27,28,1,0,0,0,28,26,1,0,0,0,28,29,1,0,0,0,29,33,1,0,0,0,30,32,3,2,
		1,0,31,30,1,0,0,0,32,35,1,0,0,0,33,31,1,0,0,0,33,34,1,0,0,0,34,37,1,0,
		0,0,35,33,1,0,0,0,36,26,1,0,0,0,37,38,1,0,0,0,38,36,1,0,0,0,38,39,1,0,
		0,0,39,41,1,0,0,0,40,21,1,0,0,0,40,36,1,0,0,0,41,1,1,0,0,0,42,44,5,4,0,
		0,43,42,1,0,0,0,44,45,1,0,0,0,45,43,1,0,0,0,45,46,1,0,0,0,46,3,1,0,0,0,
		47,48,5,1,0,0,48,49,3,6,3,0,49,50,5,2,0,0,50,51,3,8,4,0,51,52,5,3,0,0,
		52,5,1,0,0,0,53,55,5,4,0,0,54,53,1,0,0,0,55,56,1,0,0,0,56,54,1,0,0,0,56,
		57,1,0,0,0,57,7,1,0,0,0,58,60,5,4,0,0,59,58,1,0,0,0,60,61,1,0,0,0,61,59,
		1,0,0,0,61,62,1,0,0,0,62,9,1,0,0,0,10,13,18,23,28,33,38,40,45,56,61
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}