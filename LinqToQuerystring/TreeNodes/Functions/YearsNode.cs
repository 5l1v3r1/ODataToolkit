﻿namespace LinqToQuerystring.TreeNodes.Functions
{
  using System;
  using System.Linq;
  using System.Linq.Expressions;

  using LinqToQuerystring.Exceptions;
  using LinqToQuerystring.TreeNodes.Base;

  public class YearsNode : SingleChildNode
  {
    public YearsNode(Token payload) : base(payload) { }

    public override Expression BuildLinqExpression(IQueryable query, Type inputType, Expression expression, Expression item = null)
    {
      var childexpression = this.ChildNode.BuildLinqExpression(query, inputType, expression, item);

      if (!typeof(DateTime).IsAssignableFrom(childexpression.Type))
      {
        throw new FunctionNotSupportedException(childexpression.Type, "years");
      }

      return Expression.Property(childexpression, "Year");
    }
  }
}