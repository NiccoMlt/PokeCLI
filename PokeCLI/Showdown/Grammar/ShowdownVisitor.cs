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
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="ShowdownParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public interface IShowdownVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="ShowdownParser.team"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTeam([NotNull] ShowdownParser.TeamContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ShowdownParser.pokemon"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPokemon([NotNull] ShowdownParser.PokemonContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ShowdownParser.nickname"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNickname([NotNull] ShowdownParser.NicknameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ShowdownParser.specie"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSpecie([NotNull] ShowdownParser.SpecieContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ShowdownParser.sex"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSex([NotNull] ShowdownParser.SexContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ShowdownParser.item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitItem([NotNull] ShowdownParser.ItemContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ShowdownParser.ability"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAbility([NotNull] ShowdownParser.AbilityContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ShowdownParser.level"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLevel([NotNull] ShowdownParser.LevelContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ShowdownParser.shiny"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShiny([NotNull] ShowdownParser.ShinyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ShowdownParser.happiness"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHappiness([NotNull] ShowdownParser.HappinessContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ShowdownParser.evs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEvs([NotNull] ShowdownParser.EvsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ShowdownParser.stats"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStats([NotNull] ShowdownParser.StatsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ShowdownParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStat([NotNull] ShowdownParser.StatContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ShowdownParser.nature"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNature([NotNull] ShowdownParser.NatureContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ShowdownParser.ivs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIvs([NotNull] ShowdownParser.IvsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ShowdownParser.moves"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMoves([NotNull] ShowdownParser.MovesContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ShowdownParser.move"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMove([NotNull] ShowdownParser.MoveContext context);
}
} // namespace PokeCLI.Showdown.Grammar
