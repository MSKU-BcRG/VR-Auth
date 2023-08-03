<<<<<<< HEAD
using UnityEngine;
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner
{
    [InitializeOnLoad]
    static class RerunCallbackInitializer
    {
        static RerunCallbackInitializer()
        {
            var testRunnerApi = ScriptableObject.CreateInstance<TestRunnerApi>();

            var rerunCallback = ScriptableObject.CreateInstance<RerunCallback>();
            testRunnerApi.RegisterCallbacks<RerunCallback>(rerunCallback);
        }
    }
}
=======
using UnityEngine;
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner
{
    [InitializeOnLoad]
    static class RerunCallbackInitializer
    {
        static RerunCallbackInitializer()
        {
            var testRunnerApi = ScriptableObject.CreateInstance<TestRunnerApi>();

            var rerunCallback = ScriptableObject.CreateInstance<RerunCallback>();
            testRunnerApi.RegisterCallbacks<RerunCallback>(rerunCallback);
        }
    }
}
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
