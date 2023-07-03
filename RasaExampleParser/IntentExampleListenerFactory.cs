namespace Reefact.RasaIntentExampleParser {

    // ReSharper disable once IdentifierTypo
    public interface IntentExampleListenerFactory<out TOutput> {

        IntentExampleListener<TOutput> Create();

    }

}