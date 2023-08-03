<<<<<<< HEAD
using UnityEngine;
using UnityEngine.TestTools.TestRunner;

namespace UnityEditor.TestTools.TestRunner.Api
{
    internal class CallbacksDelegatorListener : ScriptableObject, ITestRunnerListener
    {
        public void RunStarted(NUnit.Framework.Interfaces.ITest testsToRun)
        {
            CallbacksDelegator.instance.RunStarted(testsToRun);
        }

        public void RunFinished(NUnit.Framework.Interfaces.ITestResult testResults)
        {
            CallbacksDelegator.instance.RunFinished(testResults);
        }

        public void TestStarted(NUnit.Framework.Interfaces.ITest test)
        {
            CallbacksDelegator.instance.TestStarted(test);
        }

        public void TestFinished(NUnit.Framework.Interfaces.ITestResult result)
        {
            CallbacksDelegator.instance.TestFinished(result);
        }
    }
}
=======
using UnityEngine;
using UnityEngine.TestTools.TestRunner;

namespace UnityEditor.TestTools.TestRunner.Api
{
    internal class CallbacksDelegatorListener : ScriptableObject, ITestRunnerListener
    {
        public void RunStarted(NUnit.Framework.Interfaces.ITest testsToRun)
        {
            CallbacksDelegator.instance.RunStarted(testsToRun);
        }

        public void RunFinished(NUnit.Framework.Interfaces.ITestResult testResults)
        {
            CallbacksDelegator.instance.RunFinished(testResults);
        }

        public void TestStarted(NUnit.Framework.Interfaces.ITest test)
        {
            CallbacksDelegator.instance.TestStarted(test);
        }

        public void TestFinished(NUnit.Framework.Interfaces.ITestResult result)
        {
            CallbacksDelegator.instance.TestFinished(result);
        }
    }
}
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
