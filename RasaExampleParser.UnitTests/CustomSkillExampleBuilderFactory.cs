#region Usings declarations

#endregion

namespace Reefact.RasaIntentExampleParser.UnitTests {

    internal sealed class CustomSkillExampleBuilderFactory : SkillExampleBuilderFactory<SkillExample> {

        /// <inheritdoc />
        public SkillExampleBuilder<SkillExample> Create() {
            return new CustomSkillExampleBuilder();
        }

    }

}