<<<<<<< HEAD
using System;
using UnityEditor.TestRunner.TestLaunchers;
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.CommandLineTest
{
    [Serializable]
    internal class LogSavingCallbacks : ScriptableObject, ICallbacks
    {
        public void RunStarted(ITestAdaptor testsToRun)
        {
            RemotePlayerLogController.instance.StartLogWriters();
        }

        public virtual void RunFinished(ITestResultAdaptor testResults)
        {
            RemotePlayerLogController.instance.StopLogWriters();
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
using UnityEditor.TestRunner.TestLaunchers;
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.CommandLineTest
{
    [Serializable]
    internal class LogSavingCallbacks : ScriptableObject, ICallbacks
    {
        public void RunStarted(ITestAdaptor testsToRun)
        {
            RemotePlayerLogController.instance.StartLogWriters();
        }

        public virtual void RunFinished(ITestResultAdaptor testResults)
        {
            RemotePlayerLogController.instance.StopLogWriters();
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
