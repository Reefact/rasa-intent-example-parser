#region Usings declarations

using NFluent;

using Xunit;

#endregion

namespace Reefact.RasaIntentExampleParser.UnitTests {

    public class UnitTest1 {

        [Fact]
        public void Test1() {
            // Setup
            const string input  = "What is the weather {{dateTime}} in {{city}} please ?";
            var          parser = SkillExampleParser.Create(new CustomSkillExampleBuilderFactory());

            // Exercise
            SkillExample result = parser.Parse(input);

            // Verify
            Check.That(result.Elements).CountIs(5);
            Check.That(result.Elements[0]).IsEqualTo(new Text("What is the weather "));
            Check.That(result.Elements[1]).IsEqualTo(new ArgumentName("dateTime"));
            Check.That(result.Elements[2]).IsEqualTo(new Text(" in "));
            Check.That(result.Elements[3]).IsEqualTo(new ArgumentName("city"));
            Check.That(result.Elements[4]).IsEqualTo(new Text(" please ?"));
        }

        [Fact]
        public void Test2() {
            // Setup
            const string input  = "Give me information on trade {{tradeId}}";
            var          parser = SkillExampleParser.Create(new CustomSkillExampleBuilderFactory());

            // Exercise
            SkillExample result = parser.Parse(input);

            // Verify
            Check.That(result.Elements).CountIs(2);
            Check.That(result.Elements[0]).IsEqualTo(new Text("Give me information on trade "));
            Check.That(result.Elements[1]).IsEqualTo(new ArgumentName("tradeId"));
        }

    }

}