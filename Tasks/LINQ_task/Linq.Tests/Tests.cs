using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Objects;
using NUnit.Framework;
using Linq.Tests.Comparers;

namespace Linq.Tests
{
    [TestFixture]
    public class Tests
    {
        private readonly YearSchoolComparer _yearSchoolComparer = new YearSchoolComparer();
        private readonly NumberPairComparer _numberPairComparer = new NumberPairComparer();
        private readonly MaxDiscountOwnerComparer _discountOwnerComparer = new MaxDiscountOwnerComparer();
        private readonly CountryStatComparer _countryStatComparer = new CountryStatComparer();



    }
}