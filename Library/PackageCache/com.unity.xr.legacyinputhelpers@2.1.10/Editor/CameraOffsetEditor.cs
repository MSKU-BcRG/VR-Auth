<<<<<<< HEAD
﻿using System.Collections;
using UnityEngine;
using UnityEditor;

#if ENABLE_VR || ENABLE_AR
using UnityEngine.XR;

namespace UnityEditor.XR.LegacyInputHelpers
{
    [CustomEditor(typeof(CameraOffset))]
    class CameraOffsetHelperEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            GUI.enabled = false;
            EditorGUILayout.ObjectField("Script", MonoScript.FromMonoBehaviour((CameraOffset)target), typeof(CameraOffset), false);
            GUI.enabled = true;

            EditorGUILayout.PropertyField(serializedObject.FindProperty("m_CameraFloorOffsetObject"));

            EditorGUILayout.PropertyField(serializedObject.FindProperty("m_RequestedTrackingMode"));

            EditorGUILayout.PropertyField(serializedObject.FindProperty("m_CameraYOffset"));

            serializedObject.ApplyModifiedProperties();
        }
    }
}
=======
﻿using System.Collections;
using UnityEngine;
using UnityEditor;

#if ENABLE_VR || ENABLE_AR
using UnityEngine.XR;

namespace UnityEditor.XR.LegacyInputHelpers
{
    [CustomEditor(typeof(CameraOffset))]
    class CameraOffsetHelperEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            GUI.enabled = false;
            EditorGUILayout.ObjectField("Script", MonoScript.FromMonoBehaviour((CameraOffset)target), typeof(CameraOffset), false);
            GUI.enabled = true;

            EditorGUILayout.PropertyField(serializedObject.FindProperty("m_CameraFloorOffsetObject"));

            EditorGUILayout.PropertyField(serializedObject.FindProperty("m_RequestedTrackingMode"));

            EditorGUILayout.PropertyField(serializedObject.FindProperty("m_CameraYOffset"));

            serializedObject.ApplyModifiedProperties();
        }
    }
}
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
#endif