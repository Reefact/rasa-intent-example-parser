#region Usings declarations

#endregion

using System.Collections.Generic;
using System.Collections.Immutable;

namespace Reefact.RasaIntentExampleParser {

    public class CustomListener: IntentExampleListener<ImmutableArray<object>> {

        private readonly List<object>  _objects = new List<object>();
        private          EntityExample _currentEntityExample;

        /// <inheritdoc />
        public void EnterText(string text) {
            _objects.Add(text);
        }

        /// <inheritdoc />
        public void EnterEntityExample() {
            _currentEntityExample = new EntityExample();
        }

        /// <inheritdoc />
        public void ExitEntityExample() {
            _objects.Add(_currentEntityExample);
            _currentEntityExample = null;
        }

        /// <inheritdoc />
        public void EnterEntityName(string entityName) {
            _currentEntityExample.EntityName = entityName;
        }

        /// <inheritdoc />
        public void EnterEntityValue(string value) {
            _currentEntityExample.EntityValue = value;
        }

        /// <inheritdoc />
        public ImmutableArray<object> GetIntentExample() {
            return _objects.ToImmutableArray();
        }

    }
}