#region Usings declarations

using System;
using System.IO;

using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

#endregion

namespace Reefact.RasaIntentExampleParser {

    public static class SkillExampleParser {

        #region Statics members declarations

        public static SkillExampleParser<TOutput> Create<TOutput>(SkillExampleBuilderFactory<TOutput> listenerFactory) {
            return new SkillExampleParser<TOutput>(listenerFactory);
        }

        #endregion

    }

    public sealed class SkillExampleParser<TOutput> {

        #region Fields declarations

        private readonly SkillExampleBuilderFactory<TOutput> _listenerFactory;

        #endregion

        #region Constructors declarations

        internal SkillExampleParser(SkillExampleBuilderFactory<TOutput> listenerFactory) {
            if (listenerFactory is null) { throw new ArgumentNullException(nameof(listenerFactory)); }

            _listenerFactory = listenerFactory;
        }

        #endregion

        public TOutput Parse(string s) {
            if (s is null) { throw new ArgumentNullException(nameof(s)); }

            using TextReader              reader         = new StringReader(s);
            AntlrInputStream              stream         = new(reader);
            SkillExampleLexer             lexer          = new(stream);
            CommonTokenStream             tokens         = new(lexer);
            global::SkillExampleParser    parser         = new(tokens);
            IParseTree                    tree           = parser.example();
            ParseTreeWalker               walker         = new();
            SkillExampleBuilder<TOutput>  customListener = _listenerFactory.Create();
            SkillExampleListener<TOutput> listener       = new(customListener);
            walker.Walk(listener, tree);

            return customListener.Build();
        }

    }

}