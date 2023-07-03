namespace Reefact.RasaIntentExampleParser {

    // ReSharper disable once IdentifierTypo
    public interface IntentExampleListener<out TOutput> {

        void EnterText(string text);
        void EnterEntityExample();
        void ExitEntityExample();
        void EnterEntityName(string  entityName);
        void EnterEntityValue(string value);

        TOutput GetIntentExample();

    }

}