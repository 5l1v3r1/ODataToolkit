﻿//---------------------------------------------------------------------
// <copyright file="IEdmBooleanValue.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

namespace ODataToolkit.Vocabularies
{
    /// <summary>
    /// Represents an EDM boolean value.
    /// </summary>
    public interface IEdmBooleanValue : IEdmPrimitiveValue
    {
        /// <summary>
        /// Gets a value indicating whether the value of this boolean value is true or false.
        /// </summary>
        bool Value { get; }
    }
}
