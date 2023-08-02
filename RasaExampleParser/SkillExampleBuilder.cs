namespace Reefact.RasaIntentExampleParser {

    // ReSharper disable once IdentifierTypo
    public interface SkillExampleBuilder<out TSkillExample> {

        void EnterText(string         text);
        void EnterArgumentName(string argumentName);

        TSkillExample Build();

    }

}