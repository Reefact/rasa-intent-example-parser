#region Usings declarations

using System;
using System.Collections.Generic;
using System.Collections.Immutable;

#endregion

namespace Reefact.RasaIntentExampleParser.UnitTests {

    public sealed class SkillExample {

        #region Constructors declarations

        public SkillExample(IEnumerable<SkillExampleElement> elements) {
            if (elements is null) { throw new ArgumentNullException(nameof(elements)); }

            Elements = elements.ToImmutableList();
        }

        #endregion

        public ImmutableList<SkillExampleElement> Elements { get; }

    }

}