<<<<<<< HEAD
using JetBrains.Annotations;
using UnityEditor;

namespace JetBrains.Rider.Unity.Editor
{
  // Do not rename this class while you don't rename startup command for dotTrace profiler
  [UsedImplicitly]
  internal static class StartUpMethodExecutor
  {
    [UsedImplicitly]
    public static void EnterPlayMode()
    {
      EditorApplication.isPlaying = true;
    }
  }
=======
using JetBrains.Annotations;
using UnityEditor;

namespace JetBrains.Rider.Unity.Editor
{
  // Do not rename this class while you don't rename startup command for dotTrace profiler
  [UsedImplicitly]
  internal static class StartUpMethodExecutor
  {
    [UsedImplicitly]
    public static void EnterPlayMode()
    {
      EditorApplication.isPlaying = true;
    }
  }
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
}