<<<<<<< HEAD
using System;
using System.Reflection;
#if !UNITY_2021_2_OR_NEWER
using UnityEditor.Experimental.SceneManagement;
#endif
using UnityEditor.SceneManagement;

namespace Unity.AI.Navigation.Editor.Tests
{
    class PrefabSavingUtil
    {
        public static void SavePrefab(PrefabStage prefabStage)
        {
            if (prefabStage == null)
                throw new ArgumentNullException();

            var savePrefabMethod = prefabStage.GetType().GetMethod("SavePrefab", BindingFlags.NonPublic | BindingFlags.Instance);
            if (savePrefabMethod == null)
                throw new InvalidOperationException();

            savePrefabMethod.Invoke(prefabStage, null);
        }
    }
=======
using System;
using System.Reflection;
#if !UNITY_2021_2_OR_NEWER
using UnityEditor.Experimental.SceneManagement;
#endif
using UnityEditor.SceneManagement;

namespace Unity.AI.Navigation.Editor.Tests
{
    class PrefabSavingUtil
    {
        public static void SavePrefab(PrefabStage prefabStage)
        {
            if (prefabStage == null)
                throw new ArgumentNullException();

            var savePrefabMethod = prefabStage.GetType().GetMethod("SavePrefab", BindingFlags.NonPublic | BindingFlags.Instance);
            if (savePrefabMethod == null)
                throw new InvalidOperationException();

            savePrefabMethod.Invoke(prefabStage, null);
        }
    }
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
}