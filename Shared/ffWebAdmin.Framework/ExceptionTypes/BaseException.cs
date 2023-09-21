﻿using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ffWebAdmin.Framework.ExceptionTypes
{
   public class BaseException : System.Exception, ISerializable
   {
      public BaseException()
         : base()
      {
         // Add implementation (if required)
      }

      public BaseException(string message)
         : base(message)
      {
         // Add implementation (if required)
      }

      public BaseException(string message, System.Exception inner)
         : base(message, inner)
      { 
         // Add implementation (if required)
      }

      protected BaseException(SerializationInfo info, StreamingContext context)
         : base(info, context)
      { 
         // Add implementation (if required)
      }
   }
}
