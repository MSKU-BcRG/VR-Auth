<<<<<<< HEAD
﻿using System;
using System.Text.RegularExpressions;
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestRunner.NUnitExtensions.Filters
{
    internal class FullNameFilter : NUnit.Framework.Internal.Filters.FullNameFilter
    {
        public FullNameFilter(string expectedValue) : base(expectedValue)
        {
        }

        public override bool Match(ITest test)
        {
            return Match(test.GetFullNameWithoutDllPath());
        }

        protected override string ElementName => "test";

    }
}
=======
﻿using System;
using System.Text.RegularExpressions;
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestRunner.NUnitExtensions.Filters
{
    internal class FullNameFilter : NUnit.Framework.Internal.Filters.FullNameFilter
    {
        public FullNameFilter(string expectedValue) : base(expectedValue)
        {
        }

        public override bool Match(ITest test)
        {
            return Match(test.GetFullNameWithoutDllPath());
        }

        protected override string ElementName => "test";

    }
}
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
