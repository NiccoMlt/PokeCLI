using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Antlr4.Runtime;
using PokeCLI.Showdown;
using PokeCLI.Showdown.Grammar;
using Xunit;

namespace PokeCLI.Tests
{
    public class TestShowdownParser
    {
        [Theory]
        [InlineData(@"WC2019-Lax.sdt", new [] {
            @"Crobat.sdt",
            @"Incineroar.sdt",
            @"Kangaskhan.sdt",
            @"Lunala.sdt",
            @"Tapu Fini.sdt",
            @"Xerneas.sdt"
        })]
        [InlineData(@"OCIC-marc0fier0.sdt", new [] {
            @"Conkeldurr.sdt",
            @"Dracovish.sdt",
            @"Duraludon.sdt",
            @"Rotom.sdt",
            @"Sylveon.sdt",
            @"Whimsicott.sdt"
        })]
        public void ShowdownParser_Team_Parses(string filename, string[] filenames)
        {
            string basePath = Environment.CurrentDirectory
                              + Path.DirectorySeparatorChar
                              + "Resources"
                              + Path.DirectorySeparatorChar;
            var stream = new AntlrInputStream(new StreamReader(basePath + filename));
            string folderPath = basePath
                                + Path.DirectorySeparatorChar
                                + filename.Split(".")[0]
                                + Path.DirectorySeparatorChar;
            var expected = filenames.Select(file => File.ReadAllText(folderPath + file, Encoding.UTF8));
            var lexer = new ShowdownLexer(stream);
            var tokens = new CommonTokenStream(lexer);
            var parser = new ShowdownParser(tokens);
            var errorListener = new ConsoleErrorListener<IToken>();
            parser.RemoveErrorListeners();
            parser.AddErrorListener(errorListener);

            var tree = parser.team();
            var parsed = tree.pokemon().Select(pkmn => pkmn.GetFullText());
            Assert.Equal(expected.Count(), parsed.Count());

        }

        [Theory]
        [InlineData(
            @"Snowy.sdt",
            "Snowy", "Vulpix-Alola", "M", "Icium Z", "Snow Cloak", "248 HP / 8 Atk / 252 SpD", null, "Gentle",
            new [] { "Powder Snow", "Hail", "Aurora Veil", "Tackle" })]
        [InlineData(
            @"Sejun_Park’s_Pachirisu.sdt",
            null, "Pachirisu", null, "Sitrus Berry", "Volt Absorb", "252 HP / 252 Def / 4 SpD", null, "Impish",
            new [] { "Nuzzle", "Follow Me", "Super Fang", "Protect" })]
        [InlineData(
            @"OCIC-marc0fier0/Conkeldurr.sdt",
            "La Zio", "Conkeldurr", "F", "Flame Orb", "Guts", "212 HP / 156 Atk / 4 Def / 76 SpD / 60 Spe", null,
            "Adamant", new [] { "Protect", "Drain Punch", "Mach Punch", "Ice Punch" })]
        public void ShowdownParser_Pokemon_Parses(string filename,
            string? nickname, string name, string? sex, string? item,
            string ability,
            string? evs,
            string? ivs,
            string nature,
            IEnumerable<string> moves)
        {
            var stream = new AntlrInputStream(new StreamReader(
                Environment.CurrentDirectory
                + Path.DirectorySeparatorChar
                + "Resources"
                + Path.DirectorySeparatorChar
                + filename));

            var lexer = new ShowdownLexer(stream);
            var tokens = new CommonTokenStream(lexer);
            var parser = new ShowdownParser(tokens);
            var errorListener = new ConsoleErrorListener<IToken>();
            parser.RemoveErrorListeners();
            parser.AddErrorListener(errorListener);
            // var errorListener = new DiagnosticErrorListener();
            // parser.RemoveErrorListeners();
            // parser.AddErrorListener(errorListener);

            var tree = parser.pokemon();
            Assert.Equal(nickname, tree.nickname()?.GetFullText());
            Assert.Equal(name, tree.specie()?.GetFullText());
            Assert.Equal(sex, tree.sex()?.GetText());
            Assert.Equal(ability, tree.ability()?.GetFullText());
            Assert.Equal(evs, tree.evs().stats()?.GetFullText());
            Assert.Equal(ivs, tree!.ivs()?.GetText());
            Assert.Equal(nature, tree.nature()?.GetText());
            Assert.Equal(item, tree.item()?.GetFullText());
            Assert.Equal(
                moves,
                tree.moves()?.move()?.Select(context => context.GetFullText())
            );
        }
    }
}
