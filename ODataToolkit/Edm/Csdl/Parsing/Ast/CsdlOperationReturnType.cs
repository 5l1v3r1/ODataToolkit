//---------------------------------------------------------------------
// <copyright file="CsdlOperationReturnType.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

namespace ODataToolkit.Csdl.Parsing.Ast
{
    /// <summary>
    /// Represents a CSDL function return type.
    /// </summary>
    internal class CsdlOperationReturnType : CsdlElement
    {
        private readonly CsdlTypeReference returnType;

        public CsdlOperationReturnType(CsdlTypeReference returnType, CsdlLocation location)
            : base(location)
        {
            this.returnType = returnType;
        }

        public CsdlTypeReference ReturnType
        {
            get { return this.returnType; }
        }
    }
}
