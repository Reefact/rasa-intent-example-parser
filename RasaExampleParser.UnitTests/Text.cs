#region Usings declarations

using System;

#endregion

namespace Reefact.RasaIntentExampleParser.UnitTests {

    public sealed class Text : SkillExampleElement, IEquatable<Text> {

        public static bool operator ==(Text left, Text right) {
            return Equals(left, right);
        }

        public static bool operator !=(Text left, Text right) {
            return !Equals(left, right);
        }

        #region Constructors declarations

        public Text(string value) {
            if (value is null) {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value;
        }

        #endregion

        public string Value { get; }

        /// <inheritdoc />
        public bool Equals(Text other) {
            if (ReferenceEquals(null, other)) {
                return false;
            }

            if (ReferenceEquals(this, other)) {
                return true;
            }

            return Value == other.Value;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) {
            return ReferenceEquals(this, obj) || (obj is Text other && Equals(other));
        }

        /// <inheritdoc />
        public override int GetHashCode() {
            return Value.GetHashCode();
        }

    }

}