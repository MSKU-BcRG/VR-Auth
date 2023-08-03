<<<<<<< HEAD
using System;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal abstract class FileCleanupVerifierTaskBase : TestTaskBase
    {
        internal Func<string[]> GetAllAssetPathsAction = AssetDatabase.GetAllAssetPaths;
        
        protected string[] GetAllFilesInAssetsDirectory()
        {
            return GetAllAssetPathsAction();
        }
    }
=======
using System;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal abstract class FileCleanupVerifierTaskBase : TestTaskBase
    {
        internal Func<string[]> GetAllAssetPathsAction = AssetDatabase.GetAllAssetPaths;
        
        protected string[] GetAllFilesInAssetsDirectory()
        {
            return GetAllAssetPathsAction();
        }
    }
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
}