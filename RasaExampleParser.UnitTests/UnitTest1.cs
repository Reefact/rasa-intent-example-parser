#region Usings declarations

using System.Collections.Immutable;

using NFluent;

using Xunit;

#endregion

namespace Reefact.RasaIntentExampleParser.UnitTests {

    public class UnitTest1 {

        [Fact]
        public void Test1() {
            const string           input  = "What is the weather [today](date) in [Paris](place) please ?";
            var                    parser = IntentExampleParser.Create(new CustomListenerFactory());
            ImmutableArray<object> result = parser.Parse(input);
            Check.That(result.Length).IsEqualTo(5);
            Check.That(result[0]).IsEqualTo("What is the weather ");
            Check.That(result[1]).IsEqualTo(new EntityExample() { EntityName = "date", EntityValue = "today" });
            Check.That(result[2]).Equals(" in ");
            Check.That(result[3]).IsEqualTo(new EntityExample() { EntityName = "place", EntityValue = "Paris" });
            Check.That(result[4]).IsEqualTo(" please ?");
        }

    }

}