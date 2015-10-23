﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EscherAuthTests.Helpers
{
    class TestFixture
    {
        public string[] headersToSign { get; set; }
        public TestRequest request { get; set; }
        public TestEscherConfig config { get; set; }
        public TestFixtureExpectations expected { get; set; }
    }
}