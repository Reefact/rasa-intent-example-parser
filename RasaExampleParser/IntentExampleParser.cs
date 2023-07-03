#region Usings declarations

using System;
using System.IO;

using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

#endregion

namespace Reefact.RasaIntentExampleParser {

    public static class IntentExampleParser {

        #region Statics members declarations

        public static IntentExampleParser<TOutput> Create<TOutput>(IntentExampleListenerFactory<TOutput> listenerFactory) {
            return new IntentExampleParser<TOutput>(listenerFactory);
        }

        #endregion

    }

    public sealed class IntentExampleParser<TOutput> {

        #region Fields declarations

        private readonly IntentExampleListenerFactory<TOutput> _listenerFactory;

        #endregion

        #region Constructors declarations

        internal IntentExampleParser(IntentExampleListenerFactory<TOutput> listenerFactory) {
            if (listenerFactory is null) { throw new ArgumentNullException(nameof(listenerFactory)); }

            _listenerFactory = listenerFactory;
        }

        #endregion

        public TOutput Parse(string s) {
            if (s is null) { throw new ArgumentNullException(nameof(s)); }

            using TextReader                   reader         = new StringReader(s);
            AntlrInputStream                   stream         = new(reader);
            RasaIntentExampleLexer             lexer          = new(stream);
            CommonTokenStream                  tokens         = new(lexer);
            global::RasaIntentExampleParser    parser         = new(tokens);
            IParseTree                         tree           = parser.example();
            ParseTreeWalker                    walker         = new();
            IntentExampleListener<TOutput>     customListener = _listenerFactory.Create();
            RasaIntentExampleListener<TOutput> listener       = new(customListener);
            walker.Walk(listener, tree);

            return customListener.GetIntentExample();
        }

    }

}