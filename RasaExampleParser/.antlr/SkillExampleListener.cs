//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from SkillExample.g4 by ANTLR 4.13.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="SkillExampleParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.0")]
[System.CLSCompliant(false)]
public interface ISkillExampleListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="SkillExampleParser.example"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExample([NotNull] SkillExampleParser.ExampleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SkillExampleParser.example"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExample([NotNull] SkillExampleParser.ExampleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SkillExampleParser.text"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterText([NotNull] SkillExampleParser.TextContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SkillExampleParser.text"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitText([NotNull] SkillExampleParser.TextContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SkillExampleParser.argumentName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArgumentName([NotNull] SkillExampleParser.ArgumentNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SkillExampleParser.argumentName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArgumentName([NotNull] SkillExampleParser.ArgumentNameContext context);
}
