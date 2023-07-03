#region Usings declarations

using System;

#endregion

namespace Reefact.RasaIntentExampleParser {

    internal class RasaIntentExampleListener<TOutput> : RasaIntentExampleBaseListener {

        #region Fields declarations

        private readonly IntentExampleListener<TOutput> _customListener;

        #endregion

        #region Constructors declarations

        public RasaIntentExampleListener(IntentExampleListener<TOutput> customListener) {
            if (customListener is null) { throw new ArgumentNullException(nameof(customListener)); }

            _customListener = customListener;
        }

        #endregion

        /// <inheritdoc />
        public override void EnterText(global::RasaIntentExampleParser.TextContext context) {
            string text = context.GetText();
            _customListener.EnterText(text);
        }

        /// <inheritdoc />
        public override void EnterEntityExample(global::RasaIntentExampleParser.EntityExampleContext context) {
            _customListener.EnterEntityExample();
        }

        /// <inheritdoc />
        public override void ExitEntityExample(global::RasaIntentExampleParser.EntityExampleContext context) {
            _customListener.ExitEntityExample();
        }

        /// <inheritdoc />
        public override void EnterEntityName(global::RasaIntentExampleParser.EntityNameContext context) {
            string entityName = context.GetText();
            _customListener.EnterEntityName(entityName);
        }

        /// <inheritdoc />
        public override void EnterEntityValue(global::RasaIntentExampleParser.EntityValueContext context) {
            string entityValue = context.GetText();
            _customListener.EnterEntityValue(entityValue);
        }

    }

}