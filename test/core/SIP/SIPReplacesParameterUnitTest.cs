﻿//-----------------------------------------------------------------------------
// Author(s):
// Aaron Clauson
// 
// History:
// 
//
// License: 
// BSD 3-Clause "New" or "Revised" License, see included LICENSE.md file.
//-----------------------------------------------------------------------------

using System;
using Xunit;

namespace SIPSorcery.SIP.UnitTests
{
    [Trait("Category", "unit")]
    public class SIPReplacesParameterUnitTest
    {
        [Fact]
        public void ParamsInUserPortionURITest()
        {
            Console.WriteLine("--> " + System.Reflection.MethodBase.GetCurrentMethod().Name);

            var replaces = SIPReplacesParameter.Parse(SIPEscape.SIPURIParameterUnescape("a48484fb-ac6e00aa%4010.0.0.12%3Bfrom-tag%3D11e7a0c7ec2ab74eo0%3Bto-tag%3D1313732478"));

            Assert.Equal("a48484fb-ac6e00aa@10.0.0.12", replaces.CallID);
            Assert.Equal("1313732478", replaces.ToTag);
            Assert.Equal("11e7a0c7ec2ab74eo0", replaces.FromTag);

            Console.WriteLine("-----------------------------------------");
        }
    }
}
