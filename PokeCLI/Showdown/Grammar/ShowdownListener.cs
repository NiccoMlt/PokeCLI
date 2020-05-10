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

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;

namespace PokeCLI.Showdown.Grammar
{
    /// <summary>
    /// This interface defines a complete listener for a parse tree produced by
    /// <see cref="ShowdownParser"/>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
    [System.CLSCompliant(false)]
    public interface IShowdownListener : IParseTreeListener {
        /// <summary>
        /// Enter a parse tree produced by <see cref="ShowdownParser.team"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterTeam([NotNull] ShowdownParser.TeamContext context);
        /// <summary>
        /// Exit a parse tree produced by <see cref="ShowdownParser.team"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitTeam([NotNull] ShowdownParser.TeamContext context);
        /// <summary>
        /// Enter a parse tree produced by <see cref="ShowdownParser.pokemon"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterPokemon([NotNull] ShowdownParser.PokemonContext context);
        /// <summary>
        /// Exit a parse tree produced by <see cref="ShowdownParser.pokemon"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitPokemon([NotNull] ShowdownParser.PokemonContext context);
        /// <summary>
        /// Enter a parse tree produced by <see cref="ShowdownParser.nickname"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterNickname([NotNull] ShowdownParser.NicknameContext context);
        /// <summary>
        /// Exit a parse tree produced by <see cref="ShowdownParser.nickname"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitNickname([NotNull] ShowdownParser.NicknameContext context);
        /// <summary>
        /// Enter a parse tree produced by <see cref="ShowdownParser.name"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterName([NotNull] ShowdownParser.NameContext context);
        /// <summary>
        /// Exit a parse tree produced by <see cref="ShowdownParser.name"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitName([NotNull] ShowdownParser.NameContext context);
        /// <summary>
        /// Enter a parse tree produced by <see cref="ShowdownParser.sex"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterSex([NotNull] ShowdownParser.SexContext context);
        /// <summary>
        /// Exit a parse tree produced by <see cref="ShowdownParser.sex"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitSex([NotNull] ShowdownParser.SexContext context);
        /// <summary>
        /// Enter a parse tree produced by <see cref="ShowdownParser.item"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterItem([NotNull] ShowdownParser.ItemContext context);
        /// <summary>
        /// Exit a parse tree produced by <see cref="ShowdownParser.item"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitItem([NotNull] ShowdownParser.ItemContext context);
        /// <summary>
        /// Enter a parse tree produced by <see cref="ShowdownParser.ability"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterAbility([NotNull] ShowdownParser.AbilityContext context);
        /// <summary>
        /// Exit a parse tree produced by <see cref="ShowdownParser.ability"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitAbility([NotNull] ShowdownParser.AbilityContext context);
        /// <summary>
        /// Enter a parse tree produced by <see cref="ShowdownParser.level"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterLevel([NotNull] ShowdownParser.LevelContext context);
        /// <summary>
        /// Exit a parse tree produced by <see cref="ShowdownParser.level"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitLevel([NotNull] ShowdownParser.LevelContext context);
        /// <summary>
        /// Enter a parse tree produced by <see cref="ShowdownParser.shiny"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterShiny([NotNull] ShowdownParser.ShinyContext context);
        /// <summary>
        /// Exit a parse tree produced by <see cref="ShowdownParser.shiny"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitShiny([NotNull] ShowdownParser.ShinyContext context);
        /// <summary>
        /// Enter a parse tree produced by <see cref="ShowdownParser.happiness"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterHappiness([NotNull] ShowdownParser.HappinessContext context);
        /// <summary>
        /// Exit a parse tree produced by <see cref="ShowdownParser.happiness"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitHappiness([NotNull] ShowdownParser.HappinessContext context);
        /// <summary>
        /// Enter a parse tree produced by <see cref="ShowdownParser.evs"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterEvs([NotNull] ShowdownParser.EvsContext context);
        /// <summary>
        /// Exit a parse tree produced by <see cref="ShowdownParser.evs"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitEvs([NotNull] ShowdownParser.EvsContext context);
        /// <summary>
        /// Enter a parse tree produced by <see cref="ShowdownParser.stats"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterStats([NotNull] ShowdownParser.StatsContext context);
        /// <summary>
        /// Exit a parse tree produced by <see cref="ShowdownParser.stats"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitStats([NotNull] ShowdownParser.StatsContext context);
        /// <summary>
        /// Enter a parse tree produced by <see cref="ShowdownParser.stat"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterStat([NotNull] ShowdownParser.StatContext context);
        /// <summary>
        /// Exit a parse tree produced by <see cref="ShowdownParser.stat"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitStat([NotNull] ShowdownParser.StatContext context);
        /// <summary>
        /// Enter a parse tree produced by <see cref="ShowdownParser.nature"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterNature([NotNull] ShowdownParser.NatureContext context);
        /// <summary>
        /// Exit a parse tree produced by <see cref="ShowdownParser.nature"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitNature([NotNull] ShowdownParser.NatureContext context);
        /// <summary>
        /// Enter a parse tree produced by <see cref="ShowdownParser.ivs"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterIvs([NotNull] ShowdownParser.IvsContext context);
        /// <summary>
        /// Exit a parse tree produced by <see cref="ShowdownParser.ivs"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitIvs([NotNull] ShowdownParser.IvsContext context);
        /// <summary>
        /// Enter a parse tree produced by <see cref="ShowdownParser.moves"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterMoves([NotNull] ShowdownParser.MovesContext context);
        /// <summary>
        /// Exit a parse tree produced by <see cref="ShowdownParser.moves"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitMoves([NotNull] ShowdownParser.MovesContext context);
        /// <summary>
        /// Enter a parse tree produced by <see cref="ShowdownParser.move"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterMove([NotNull] ShowdownParser.MoveContext context);
        /// <summary>
        /// Exit a parse tree produced by <see cref="ShowdownParser.move"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitMove([NotNull] ShowdownParser.MoveContext context);
    }
}