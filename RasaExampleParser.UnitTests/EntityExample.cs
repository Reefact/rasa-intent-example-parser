using System;

namespace Reefact.RasaIntentExampleParser {

    public sealed class EntityExample : IEquatable<EntityExample> {

        public static bool operator ==(EntityExample left, EntityExample right) {
            return Equals(left, right);
        }

        public static bool operator !=(EntityExample left, EntityExample right) {
            return !Equals(left, right);
        }

        public string EntityName  { get; set; }
        public string EntityValue { get; set; }

        /// <inheritdoc />
        public bool Equals(EntityExample other) {
            if (ReferenceEquals(null, other)) { return false; }
            if (ReferenceEquals(this, other)) { return true; }

            return EntityName == other.EntityName && EntityValue == other.EntityValue;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) {
            return ReferenceEquals(this, obj) || (obj is EntityExample other && Equals(other));
        }

        /// <inheritdoc />
        public override int GetHashCode() {
            return HashCode.Combine(EntityName, EntityValue);
        }

    }

}