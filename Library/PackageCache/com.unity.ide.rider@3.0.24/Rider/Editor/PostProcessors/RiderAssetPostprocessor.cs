<<<<<<< HEAD
using Unity.CodeEditor;
using UnityEditor;

namespace Packages.Rider.Editor.PostProcessors
{
  internal class RiderAssetPostprocessor: AssetPostprocessor
  {
    public static bool OnPreGeneratingCSProjectFiles()
    {
      var path = RiderScriptEditor.GetEditorRealPath(CodeEditor.CurrentEditorInstallation);
      if (RiderScriptEditor.IsRiderOrFleetInstallation(path))
        return !ProjectGeneration.ProjectGeneration.isRiderProjectGeneration;
      return false;
    }
  }
=======
using Unity.CodeEditor;
using UnityEditor;

namespace Packages.Rider.Editor.PostProcessors
{
  internal class RiderAssetPostprocessor: AssetPostprocessor
  {
    public static bool OnPreGeneratingCSProjectFiles()
    {
      var path = RiderScriptEditor.GetEditorRealPath(CodeEditor.CurrentEditorInstallation);
      if (RiderScriptEditor.IsRiderOrFleetInstallation(path))
        return !ProjectGeneration.ProjectGeneration.isRiderProjectGeneration;
      return false;
    }
  }
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
}