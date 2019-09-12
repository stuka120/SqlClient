﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Xunit;

namespace Microsoft.Data.SqlClient.ManualTesting.Tests
{
    public class CheckConnStrSetupFactAttribute : FactAttribute
    {
        public CheckConnStrSetupFactAttribute()
        {
            if (!DataTestUtility.AreConnStringsSetup())
            {
                Skip = "Connection Strings Not Setup";
            }
        }
    }
}