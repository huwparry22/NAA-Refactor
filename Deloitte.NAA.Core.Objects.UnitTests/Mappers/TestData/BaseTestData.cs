﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deloitte.NAA.Core.Objects.UnitTests.Mappers.TestData
{
    public class BaseTestData<TObjOne, TObjTwo>
        where TObjOne : class, new()
        where TObjTwo : class, new()
    {
        public TObjOne ObjOne { get; set; }

        public TObjTwo ObjTwo { get; set; }

        public bool ExpectException { get; set; }

        public Type ExceptionType { get; set; }
    }
}