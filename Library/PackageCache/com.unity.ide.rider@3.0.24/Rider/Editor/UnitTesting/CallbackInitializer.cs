<<<<<<< HEAD
#if TEST_FRAMEWORK
using UnityEditor;
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine;

namespace Packages.Rider.Editor.UnitTesting
{
  [InitializeOnLoad]
  internal static class CallbackInitializer
  {
    static CallbackInitializer()
    {
      if (CallbackData.instance.isRider)
        ScriptableObject.CreateInstance<TestRunnerApi>().RegisterCallbacks(ScriptableObject.CreateInstance<TestsCallback>(), 0);
    }
  }
}
=======
#if TEST_FRAMEWORK
using UnityEditor;
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine;

namespace Packages.Rider.Editor.UnitTesting
{
  [InitializeOnLoad]
  internal static class CallbackInitializer
  {
    static CallbackInitializer()
    {
      if (CallbackData.instance.isRider)
        ScriptableObject.CreateInstance<TestRunnerApi>().RegisterCallbacks(ScriptableObject.CreateInstance<TestsCallback>(), 0);
    }
  }
}
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
#endif