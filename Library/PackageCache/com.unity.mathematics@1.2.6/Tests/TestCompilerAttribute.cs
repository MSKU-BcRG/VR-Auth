<<<<<<< HEAD
using System;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Burst.Compiler.IL.Tests
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class WindowsOnlyAttribute : Attribute
    {
        public WindowsOnlyAttribute(string reason)
        {
        }
    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public sealed class TestCompilerAttribute : TestCaseAttribute, ITestBuilder
    {
    }
}
=======
using System;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Burst.Compiler.IL.Tests
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class WindowsOnlyAttribute : Attribute
    {
        public WindowsOnlyAttribute(string reason)
        {
        }
    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public sealed class TestCompilerAttribute : TestCaseAttribute, ITestBuilder
    {
    }
}
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
