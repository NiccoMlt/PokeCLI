//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Showdown.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace PokeCLI.Showdown.Grammar {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class ShowdownLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, HP=16, ATK=17, 
		DEF=18, SP_ATK=19, SP_DEF=20, SPE=21, COLON=22, NEWLINE=23, NUMBER=24, 
		WORD=25, WHITESPACE=26, ANY=27;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "LOWERCASE", "UPPERCASE", 
		"DIGIT", "HP", "ATK", "DEF", "SP_ATK", "SP_DEF", "SPE", "COLON", "NEWLINE", 
		"NUMBER", "WORD", "WHITESPACE", "ANY"
	};


	public ShowdownLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public ShowdownLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'('", "')'", "'Ability'", "'Level'", "'Shiny'", "'Happiness'", 
		"'Nature'", "'M'", "'F'", "'@'", "'Yes'", "'EVs'", "'/'", "'IVs'", "'-'", 
		"'HP'", "'Atk'", "'Def'", "'SpA'", "'SpD'", "'Spe'", "':'", null, null, 
		null, "' '"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, "HP", "ATK", "DEF", "SP_ATK", "SP_DEF", "SPE", 
		"COLON", "NEWLINE", "NUMBER", "WORD", "WHITESPACE", "ANY"
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

	public override string GrammarFileName { get { return "Showdown.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static ShowdownLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x1D', '\xB4', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', 
		'\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', 
		'\t', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\f', 
		'\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', 
		'\r', '\x3', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', 
		'\x3', '\xF', '\x3', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x11', 
		'\x3', '\x11', '\x3', '\x12', '\x3', '\x12', '\x3', '\x13', '\x3', '\x13', 
		'\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x15', '\x3', '\x15', 
		'\x3', '\x15', '\x3', '\x15', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', 
		'\x3', '\x16', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', 
		'\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', '\x19', 
		'\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', '\x1A', '\x3', '\x1A', 
		'\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x5', '\x1B', '\xA1', '\n', 
		'\x1B', '\x3', '\x1C', '\x6', '\x1C', '\xA4', '\n', '\x1C', '\r', '\x1C', 
		'\xE', '\x1C', '\xA5', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x6', 
		'\x1D', '\xAB', '\n', '\x1D', '\r', '\x1D', '\xE', '\x1D', '\xAC', '\x3', 
		'\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1F', '\x3', 
		'\x1F', '\x2', '\x2', ' ', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', 
		'\x6', '\v', '\a', '\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', 
		'\x15', '\f', '\x17', '\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', 
		'\x1F', '\x11', '!', '\x2', '#', '\x2', '%', '\x2', '\'', '\x12', ')', 
		'\x13', '+', '\x14', '-', '\x15', '/', '\x16', '\x31', '\x17', '\x33', 
		'\x18', '\x35', '\x19', '\x37', '\x1A', '\x39', '\x1B', ';', '\x1C', '=', 
		'\x1D', '\x3', '\x2', '\a', '\x3', '\x2', '\x63', '|', '\x3', '\x2', '\x43', 
		'\\', '\x3', '\x2', '\x32', ';', '\x4', '\x2', '\f', '\f', '\xF', '\xF', 
		'\x6', '\x2', ')', ')', '/', '/', ']', ']', '_', '_', '\x2', '\xB5', '\x2', 
		'\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', 
		'\x2', '\x2', '\x2', '\x2', ')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'/', '\x3', '\x2', '\x2', '\x2', '\x2', '\x31', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x33', '\x3', '\x2', '\x2', '\x2', '\x2', '\x35', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x37', '\x3', '\x2', '\x2', '\x2', '\x2', '\x39', 
		'\x3', '\x2', '\x2', '\x2', '\x2', ';', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'=', '\x3', '\x2', '\x2', '\x2', '\x3', '?', '\x3', '\x2', '\x2', '\x2', 
		'\x5', '\x41', '\x3', '\x2', '\x2', '\x2', '\a', '\x43', '\x3', '\x2', 
		'\x2', '\x2', '\t', 'K', '\x3', '\x2', '\x2', '\x2', '\v', 'Q', '\x3', 
		'\x2', '\x2', '\x2', '\r', 'W', '\x3', '\x2', '\x2', '\x2', '\xF', '\x61', 
		'\x3', '\x2', '\x2', '\x2', '\x11', 'h', '\x3', '\x2', '\x2', '\x2', '\x13', 
		'j', '\x3', '\x2', '\x2', '\x2', '\x15', 'l', '\x3', '\x2', '\x2', '\x2', 
		'\x17', 'n', '\x3', '\x2', '\x2', '\x2', '\x19', 'r', '\x3', '\x2', '\x2', 
		'\x2', '\x1B', 'v', '\x3', '\x2', '\x2', '\x2', '\x1D', 'x', '\x3', '\x2', 
		'\x2', '\x2', '\x1F', '|', '\x3', '\x2', '\x2', '\x2', '!', '~', '\x3', 
		'\x2', '\x2', '\x2', '#', '\x80', '\x3', '\x2', '\x2', '\x2', '%', '\x82', 
		'\x3', '\x2', '\x2', '\x2', '\'', '\x84', '\x3', '\x2', '\x2', '\x2', 
		')', '\x87', '\x3', '\x2', '\x2', '\x2', '+', '\x8B', '\x3', '\x2', '\x2', 
		'\x2', '-', '\x8F', '\x3', '\x2', '\x2', '\x2', '/', '\x93', '\x3', '\x2', 
		'\x2', '\x2', '\x31', '\x97', '\x3', '\x2', '\x2', '\x2', '\x33', '\x9B', 
		'\x3', '\x2', '\x2', '\x2', '\x35', '\xA0', '\x3', '\x2', '\x2', '\x2', 
		'\x37', '\xA3', '\x3', '\x2', '\x2', '\x2', '\x39', '\xAA', '\x3', '\x2', 
		'\x2', '\x2', ';', '\xAE', '\x3', '\x2', '\x2', '\x2', '=', '\xB2', '\x3', 
		'\x2', '\x2', '\x2', '?', '@', '\a', '*', '\x2', '\x2', '@', '\x4', '\x3', 
		'\x2', '\x2', '\x2', '\x41', '\x42', '\a', '+', '\x2', '\x2', '\x42', 
		'\x6', '\x3', '\x2', '\x2', '\x2', '\x43', '\x44', '\a', '\x43', '\x2', 
		'\x2', '\x44', '\x45', '\a', '\x64', '\x2', '\x2', '\x45', '\x46', '\a', 
		'k', '\x2', '\x2', '\x46', 'G', '\a', 'n', '\x2', '\x2', 'G', 'H', '\a', 
		'k', '\x2', '\x2', 'H', 'I', '\a', 'v', '\x2', '\x2', 'I', 'J', '\a', 
		'{', '\x2', '\x2', 'J', '\b', '\x3', '\x2', '\x2', '\x2', 'K', 'L', '\a', 
		'N', '\x2', '\x2', 'L', 'M', '\a', 'g', '\x2', '\x2', 'M', 'N', '\a', 
		'x', '\x2', '\x2', 'N', 'O', '\a', 'g', '\x2', '\x2', 'O', 'P', '\a', 
		'n', '\x2', '\x2', 'P', '\n', '\x3', '\x2', '\x2', '\x2', 'Q', 'R', '\a', 
		'U', '\x2', '\x2', 'R', 'S', '\a', 'j', '\x2', '\x2', 'S', 'T', '\a', 
		'k', '\x2', '\x2', 'T', 'U', '\a', 'p', '\x2', '\x2', 'U', 'V', '\a', 
		'{', '\x2', '\x2', 'V', '\f', '\x3', '\x2', '\x2', '\x2', 'W', 'X', '\a', 
		'J', '\x2', '\x2', 'X', 'Y', '\a', '\x63', '\x2', '\x2', 'Y', 'Z', '\a', 
		'r', '\x2', '\x2', 'Z', '[', '\a', 'r', '\x2', '\x2', '[', '\\', '\a', 
		'k', '\x2', '\x2', '\\', ']', '\a', 'p', '\x2', '\x2', ']', '^', '\a', 
		'g', '\x2', '\x2', '^', '_', '\a', 'u', '\x2', '\x2', '_', '`', '\a', 
		'u', '\x2', '\x2', '`', '\xE', '\x3', '\x2', '\x2', '\x2', '\x61', '\x62', 
		'\a', 'P', '\x2', '\x2', '\x62', '\x63', '\a', '\x63', '\x2', '\x2', '\x63', 
		'\x64', '\a', 'v', '\x2', '\x2', '\x64', '\x65', '\a', 'w', '\x2', '\x2', 
		'\x65', '\x66', '\a', 't', '\x2', '\x2', '\x66', 'g', '\a', 'g', '\x2', 
		'\x2', 'g', '\x10', '\x3', '\x2', '\x2', '\x2', 'h', 'i', '\a', 'O', '\x2', 
		'\x2', 'i', '\x12', '\x3', '\x2', '\x2', '\x2', 'j', 'k', '\a', 'H', '\x2', 
		'\x2', 'k', '\x14', '\x3', '\x2', '\x2', '\x2', 'l', 'm', '\a', '\x42', 
		'\x2', '\x2', 'm', '\x16', '\x3', '\x2', '\x2', '\x2', 'n', 'o', '\a', 
		'[', '\x2', '\x2', 'o', 'p', '\a', 'g', '\x2', '\x2', 'p', 'q', '\a', 
		'u', '\x2', '\x2', 'q', '\x18', '\x3', '\x2', '\x2', '\x2', 'r', 's', 
		'\a', 'G', '\x2', '\x2', 's', 't', '\a', 'X', '\x2', '\x2', 't', 'u', 
		'\a', 'u', '\x2', '\x2', 'u', '\x1A', '\x3', '\x2', '\x2', '\x2', 'v', 
		'w', '\a', '\x31', '\x2', '\x2', 'w', '\x1C', '\x3', '\x2', '\x2', '\x2', 
		'x', 'y', '\a', 'K', '\x2', '\x2', 'y', 'z', '\a', 'X', '\x2', '\x2', 
		'z', '{', '\a', 'u', '\x2', '\x2', '{', '\x1E', '\x3', '\x2', '\x2', '\x2', 
		'|', '}', '\a', '/', '\x2', '\x2', '}', ' ', '\x3', '\x2', '\x2', '\x2', 
		'~', '\x7F', '\t', '\x2', '\x2', '\x2', '\x7F', '\"', '\x3', '\x2', '\x2', 
		'\x2', '\x80', '\x81', '\t', '\x3', '\x2', '\x2', '\x81', '$', '\x3', 
		'\x2', '\x2', '\x2', '\x82', '\x83', '\t', '\x4', '\x2', '\x2', '\x83', 
		'&', '\x3', '\x2', '\x2', '\x2', '\x84', '\x85', '\a', 'J', '\x2', '\x2', 
		'\x85', '\x86', '\a', 'R', '\x2', '\x2', '\x86', '(', '\x3', '\x2', '\x2', 
		'\x2', '\x87', '\x88', '\a', '\x43', '\x2', '\x2', '\x88', '\x89', '\a', 
		'v', '\x2', '\x2', '\x89', '\x8A', '\a', 'm', '\x2', '\x2', '\x8A', '*', 
		'\x3', '\x2', '\x2', '\x2', '\x8B', '\x8C', '\a', '\x46', '\x2', '\x2', 
		'\x8C', '\x8D', '\a', 'g', '\x2', '\x2', '\x8D', '\x8E', '\a', 'h', '\x2', 
		'\x2', '\x8E', ',', '\x3', '\x2', '\x2', '\x2', '\x8F', '\x90', '\a', 
		'U', '\x2', '\x2', '\x90', '\x91', '\a', 'r', '\x2', '\x2', '\x91', '\x92', 
		'\a', '\x43', '\x2', '\x2', '\x92', '.', '\x3', '\x2', '\x2', '\x2', '\x93', 
		'\x94', '\a', 'U', '\x2', '\x2', '\x94', '\x95', '\a', 'r', '\x2', '\x2', 
		'\x95', '\x96', '\a', '\x46', '\x2', '\x2', '\x96', '\x30', '\x3', '\x2', 
		'\x2', '\x2', '\x97', '\x98', '\a', 'U', '\x2', '\x2', '\x98', '\x99', 
		'\a', 'r', '\x2', '\x2', '\x99', '\x9A', '\a', 'g', '\x2', '\x2', '\x9A', 
		'\x32', '\x3', '\x2', '\x2', '\x2', '\x9B', '\x9C', '\a', '<', '\x2', 
		'\x2', '\x9C', '\x34', '\x3', '\x2', '\x2', '\x2', '\x9D', '\x9E', '\a', 
		'\xF', '\x2', '\x2', '\x9E', '\xA1', '\a', '\f', '\x2', '\x2', '\x9F', 
		'\xA1', '\t', '\x5', '\x2', '\x2', '\xA0', '\x9D', '\x3', '\x2', '\x2', 
		'\x2', '\xA0', '\x9F', '\x3', '\x2', '\x2', '\x2', '\xA1', '\x36', '\x3', 
		'\x2', '\x2', '\x2', '\xA2', '\xA4', '\x5', '%', '\x13', '\x2', '\xA3', 
		'\xA2', '\x3', '\x2', '\x2', '\x2', '\xA4', '\xA5', '\x3', '\x2', '\x2', 
		'\x2', '\xA5', '\xA3', '\x3', '\x2', '\x2', '\x2', '\xA5', '\xA6', '\x3', 
		'\x2', '\x2', '\x2', '\xA6', '\x38', '\x3', '\x2', '\x2', '\x2', '\xA7', 
		'\xAB', '\x5', '!', '\x11', '\x2', '\xA8', '\xAB', '\x5', '#', '\x12', 
		'\x2', '\xA9', '\xAB', '\t', '\x6', '\x2', '\x2', '\xAA', '\xA7', '\x3', 
		'\x2', '\x2', '\x2', '\xAA', '\xA8', '\x3', '\x2', '\x2', '\x2', '\xAA', 
		'\xA9', '\x3', '\x2', '\x2', '\x2', '\xAB', '\xAC', '\x3', '\x2', '\x2', 
		'\x2', '\xAC', '\xAA', '\x3', '\x2', '\x2', '\x2', '\xAC', '\xAD', '\x3', 
		'\x2', '\x2', '\x2', '\xAD', ':', '\x3', '\x2', '\x2', '\x2', '\xAE', 
		'\xAF', '\a', '\"', '\x2', '\x2', '\xAF', '\xB0', '\x3', '\x2', '\x2', 
		'\x2', '\xB0', '\xB1', '\b', '\x1E', '\x2', '\x2', '\xB1', '<', '\x3', 
		'\x2', '\x2', '\x2', '\xB2', '\xB3', '\v', '\x2', '\x2', '\x2', '\xB3', 
		'>', '\x3', '\x2', '\x2', '\x2', '\a', '\x2', '\xA0', '\xA5', '\xAA', 
		'\xAC', '\x3', '\x2', '\x3', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace PokeCLI.Showdown.Grammar
