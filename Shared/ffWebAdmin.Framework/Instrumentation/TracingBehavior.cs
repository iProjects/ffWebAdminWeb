﻿#region license
// ==============================================================================
// Microsoft patterns & practices Enterprise Library
// aExpense Reference Implementation
// ==============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
// ==============================================================================
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using ffWebAdmin.Framework.Instrumentation;
using Microsoft.Practices.Unity.InterceptionExtension;

namespace ffWebAdmin.Framework.Instrumentation
{
    /// <summary>
    /// Tracing behavior for showcasing a simple Virtual Method Interceptor scenario
    /// </summary>
    public class TracingBehavior : IInterceptionBehavior
    {
        public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)
        {
            GLEvents.Log.TracingBehaviorVirtualMethodIntercepted(input);

            return getNext()(input, getNext);
        }

        public IEnumerable<Type> GetRequiredInterfaces()
        {
            return Enumerable.Empty<Type>();
        }

        public bool WillExecute
        {
            get { return true; }
        }
    }
}