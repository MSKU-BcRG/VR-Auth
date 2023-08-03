<<<<<<< HEAD
﻿#if UNITY_2022_2_OR_NEWER

using UnityEditor.AI;
using UnityEditor;

namespace Unity.AI.Navigation.Editor
{
    internal static class ObsoleteNavigationWindowMenuEntry
    {
        [MenuItem("Window/AI/Navigation (Obsolete)", false, 1)]
        static void SetupWindow()
        {
            NavMeshEditorHelpers.SetupLegacyNavigationWindow();
        }
    }
}

#endif
=======
﻿#if UNITY_2022_2_OR_NEWER

using UnityEditor.AI;
using UnityEditor;

namespace Unity.AI.Navigation.Editor
{
    internal static class ObsoleteNavigationWindowMenuEntry
    {
        [MenuItem("Window/AI/Navigation (Obsolete)", false, 1)]
        static void SetupWindow()
        {
            NavMeshEditorHelpers.SetupLegacyNavigationWindow();
        }
    }
}

#endif
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
