﻿using System;

namespace Deloitte.NAA.Core.Objects.UnitTests.Mappers.TestData
{
    public class BaseEnumTestData<TEnumOne, TEnumTwo>
        where TEnumOne : struct, IConvertible
        where TEnumTwo : struct, IConvertible
    {
        public TEnumOne EnumOne { get; set; }

        public TEnumTwo EnumTwo { get; set; }

        public bool ExpectException { get; set; }

        public Type ExceptionType { get; set; }
    }
}
