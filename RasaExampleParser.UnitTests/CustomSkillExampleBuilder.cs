#region Usings declarations

#endregion

#region Usings declarations

using System.Collections.Generic;

#endregion

namespace Reefact.RasaIntentExampleParser.UnitTests {

    public class CustomSkillExampleBuilder : SkillExampleBuilder<SkillExample> {

        #region Fields declarations

        private readonly List<SkillExampleElement> _elements = new();

        #endregion

        /// <inheritdoc />
        public void EnterText(string text) {
            _elements.Add(new Text(text));
        }

        /// <inheritdoc />
        public void EnterArgumentName(string argumentName) {
            _elements.Add(new ArgumentName(argumentName));
        }

        /// <inheritdoc />
        public SkillExample Build() {
            return new SkillExample(_elements);
        }

    }

}