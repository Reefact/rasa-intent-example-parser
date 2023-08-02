#region Usings declarations

using System;

#endregion

namespace Reefact.RasaIntentExampleParser {

    public class SkillExampleListener<TOutput> : SkillExampleBaseListener {

        #region Fields declarations

        private readonly SkillExampleBuilder<TOutput> _customListener;

        #endregion

        #region Constructors declarations

        public SkillExampleListener(SkillExampleBuilder<TOutput> customListener) {
            if (customListener is null) { throw new ArgumentNullException(nameof(customListener)); }

            _customListener = customListener;
        }

        #endregion

        /// <inheritdoc />
        public override void EnterText(global::SkillExampleParser.TextContext context) {
            string text = context.GetText();
            _customListener.EnterText(text);
        }

        /// <inheritdoc />
        public override void EnterArgumentName(global::SkillExampleParser.ArgumentNameContext context) {
            string argumentName = context.GetText();
            _customListener.EnterArgumentName(argumentName);
        }

    }

}