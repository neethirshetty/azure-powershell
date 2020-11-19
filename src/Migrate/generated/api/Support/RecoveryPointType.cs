// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support
{

    public partial struct RecoveryPointType :
        System.IEquatable<RecoveryPointType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPointType Custom = @"Custom";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPointType LatestTag = @"LatestTag";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPointType LatestTime = @"LatestTime";

        /// <summary>the value for an instance of the <see cref="RecoveryPointType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to RecoveryPointType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="RecoveryPointType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new RecoveryPointType(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type RecoveryPointType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPointType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type RecoveryPointType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is RecoveryPointType && Equals((RecoveryPointType)obj);
        }

        /// <summary>Returns hashCode for enum RecoveryPointType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="RecoveryPointType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private RecoveryPointType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for RecoveryPointType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to RecoveryPointType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="RecoveryPointType" />.</param>

        public static implicit operator RecoveryPointType(string value)
        {
            return new RecoveryPointType(value);
        }

        /// <summary>Implicit operator to convert RecoveryPointType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="RecoveryPointType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPointType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum RecoveryPointType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPointType e1, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPointType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum RecoveryPointType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPointType e1, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPointType e2)
        {
            return e2.Equals(e1);
        }
    }
}