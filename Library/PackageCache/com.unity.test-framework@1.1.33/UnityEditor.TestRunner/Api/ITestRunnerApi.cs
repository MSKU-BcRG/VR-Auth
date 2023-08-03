<<<<<<< HEAD
using System;

namespace UnityEditor.TestTools.TestRunner.Api
{
    internal interface ITestRunnerApi
    {
        string Execute(ExecutionSettings executionSettings);
        void RegisterCallbacks<T>(T testCallbacks, int priority = 0) where T : ICallbacks;
        void UnregisterCallbacks<T>(T testCallbacks) where T : ICallbacks;
        void RetrieveTestList(TestMode testMode, Action<ITestAdaptor> callback);
    }
}
=======
using System;

namespace UnityEditor.TestTools.TestRunner.Api
{
    internal interface ITestRunnerApi
    {
        string Execute(ExecutionSettings executionSettings);
        void RegisterCallbacks<T>(T testCallbacks, int priority = 0) where T : ICallbacks;
        void UnregisterCallbacks<T>(T testCallbacks) where T : ICallbacks;
        void RetrieveTestList(TestMode testMode, Action<ITestAdaptor> callback);
    }
}
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
