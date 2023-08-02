namespace Reefact.RasaIntentExampleParser {

    // ReSharper disable once IdentifierTypo
    public interface SkillExampleBuilderFactory<out TSkillExample> {

        SkillExampleBuilder<TSkillExample> Create();

    }

}