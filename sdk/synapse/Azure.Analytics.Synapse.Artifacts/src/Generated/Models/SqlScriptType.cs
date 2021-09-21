// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The type of the SQL script. </summary>
    public readonly partial struct SqlScriptType : IEquatable<SqlScriptType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SqlScriptType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SqlScriptType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SqlQueryValue = "SqlQuery";

        /// <summary> SqlQuery. </summary>
        public static SqlScriptType SqlQuery { get; } = new SqlScriptType(SqlQueryValue);
        /// <summary> Determines if two <see cref="SqlScriptType"/> values are the same. </summary>
        public static bool operator ==(SqlScriptType left, SqlScriptType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SqlScriptType"/> values are not the same. </summary>
        public static bool operator !=(SqlScriptType left, SqlScriptType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SqlScriptType"/>. </summary>
        public static implicit operator SqlScriptType(string value) => new SqlScriptType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SqlScriptType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SqlScriptType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
