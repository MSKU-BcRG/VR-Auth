<<<<<<< HEAD
namespace UnityEditor.TestTools.TestRunner.GUI
{
    internal class AssetsDatabaseHelper : IAssetsDatabaseHelper
    {
        public void OpenAssetInItsDefaultExternalEditor(string assetPath, int line)
        {
            var asset = AssetDatabase.LoadMainAssetAtPath(assetPath);
            AssetDatabase.OpenAsset(asset, line);
        }
    }
}
=======
namespace UnityEditor.TestTools.TestRunner.GUI
{
    internal class AssetsDatabaseHelper : IAssetsDatabaseHelper
    {
        public void OpenAssetInItsDefaultExternalEditor(string assetPath, int line)
        {
            var asset = AssetDatabase.LoadMainAssetAtPath(assetPath);
            AssetDatabase.OpenAsset(asset, line);
        }
    }
}
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
