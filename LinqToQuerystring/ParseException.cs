﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqToQuerystring
{
  public class ParseException : Exception
  {
    public ParseException(string value, int location) 
      : base(string.Format("Error parsing `{0}` at location {1}", value, location)) { }
    public ParseException(string value, int location, Exception innerException) 
      : base(string.Format("Error parsing `{0}` at location {1}", value, location), innerException) { }
  }
}
