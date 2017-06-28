//---------------------------------------------------------------------
// <copyright file="IEdmLabeledExpression.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

namespace ODataToolkit.Vocabularies
{
    /// <summary>
    /// Represents an EDM labeled expression element.
    /// </summary>
    public interface IEdmLabeledExpression : IEdmNamedElement, IEdmExpression
    {
        /// <summary>
        /// Gets the underlying expression.
        /// </summary>
        IEdmExpression Expression { get; }
    }
}
