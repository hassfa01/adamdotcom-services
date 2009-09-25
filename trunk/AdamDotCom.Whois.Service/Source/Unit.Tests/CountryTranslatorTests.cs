﻿using AdamDotCom.Whois.Service;
using NUnit.Framework;

namespace Unit.Tests
{
    [TestFixture]
    public class CountryTranslatorTests
    {
        [Test]
        public void ShouldVerifyTranslatorWorks()
        {
            var countryTranslator = new CountryNameTranslator();

            Assert.IsNotNull(countryTranslator);
            Assert.AreEqual("CANADA", countryTranslator.GetCountryName("CA"));
        }
    }
}