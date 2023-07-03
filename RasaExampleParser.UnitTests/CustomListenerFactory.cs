using System.Collections.Immutable;

namespace Reefact.RasaIntentExampleParser.UnitTests {

    internal sealed class CustomListenerFactory : IntentExampleListenerFactory<ImmutableArray<object>> {

        /// <inheritdoc />
        public IntentExampleListener<ImmutableArray<object>> Create() {
            return new CustomListener();
        }

    }

}