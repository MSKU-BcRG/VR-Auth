<<<<<<< HEAD
﻿using System;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Commands;
using Unity.Profiling;

namespace UnityEngine.TestTools
{
    internal class UnityTestMethodCommand : TestMethodCommand
    {
        public UnityTestMethodCommand(TestMethod testMethod)
            : base(testMethod) { }

        public override TestResult Execute(ITestExecutionContext context)
        {
            using (new ProfilerMarker(Test.FullName).Auto())
                return base.Execute(context);
        }
    }
}
=======
﻿using System;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Commands;
using Unity.Profiling;

namespace UnityEngine.TestTools
{
    internal class UnityTestMethodCommand : TestMethodCommand
    {
        public UnityTestMethodCommand(TestMethod testMethod)
            : base(testMethod) { }

        public override TestResult Execute(ITestExecutionContext context)
        {
            using (new ProfilerMarker(Test.FullName).Auto())
                return base.Execute(context);
        }
    }
}
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
