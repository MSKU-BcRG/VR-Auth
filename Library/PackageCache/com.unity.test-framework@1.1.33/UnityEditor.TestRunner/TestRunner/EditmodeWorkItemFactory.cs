<<<<<<< HEAD
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using UnityEngine.TestRunner.NUnitExtensions.Runner;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditmodeWorkItemFactory : WorkItemFactory
    {
        protected override UnityWorkItem Create(TestMethod method, ITestFilter filter, ITest loadedTest)
        {
            return new EditorEnumeratorTestWorkItem(method, filter);
        }
    }
}
=======
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using UnityEngine.TestRunner.NUnitExtensions.Runner;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditmodeWorkItemFactory : WorkItemFactory
    {
        protected override UnityWorkItem Create(TestMethod method, ITestFilter filter, ITest loadedTest)
        {
            return new EditorEnumeratorTestWorkItem(method, filter);
        }
    }
}
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
