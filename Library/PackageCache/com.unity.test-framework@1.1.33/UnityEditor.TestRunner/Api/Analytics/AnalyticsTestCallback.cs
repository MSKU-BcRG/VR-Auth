<<<<<<< HEAD
using System;

namespace UnityEditor.TestTools.TestRunner.Api.Analytics
{
    internal class AnalyticsTestCallback : ICallbacks
    {
        private Action<ITestResultAdaptor> _runFinishedCallback;

        public AnalyticsTestCallback(Action<ITestResultAdaptor> runFinishedCallback)
        {
            _runFinishedCallback = runFinishedCallback;
        }

        public void RunStarted(ITestAdaptor testsToRun)
        {
        }

        public void RunFinished(ITestResultAdaptor result)
        {
            _runFinishedCallback(result);
        }

        public void TestStarted(ITestAdaptor test)
        {
        }

        public void TestFinished(ITestResultAdaptor result)
        {
        }
    }
}
=======
using System;

namespace UnityEditor.TestTools.TestRunner.Api.Analytics
{
    internal class AnalyticsTestCallback : ICallbacks
    {
        private Action<ITestResultAdaptor> _runFinishedCallback;

        public AnalyticsTestCallback(Action<ITestResultAdaptor> runFinishedCallback)
        {
            _runFinishedCallback = runFinishedCallback;
        }

        public void RunStarted(ITestAdaptor testsToRun)
        {
        }

        public void RunFinished(ITestResultAdaptor result)
        {
            _runFinishedCallback(result);
        }

        public void TestStarted(ITestAdaptor test)
        {
        }

        public void TestFinished(ITestResultAdaptor result)
        {
        }
    }
}
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
