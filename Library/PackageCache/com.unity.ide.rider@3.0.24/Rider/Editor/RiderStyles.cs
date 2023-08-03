<<<<<<< HEAD
using UnityEditor;
using UnityEngine;

namespace Packages.Rider.Editor
{
  internal static class RiderStyles
  {
    static RiderStyles()
    {
      LinkLabelStyle = new GUIStyle(EditorStyles.linkLabel)
      {
        padding = GUI.skin.label.padding,
        margin = GUI.skin.label.margin
      };
      LinkLabelStyle.padding.left = 0;
      LinkLabelStyle.padding.right = 0;
      LinkLabelStyle.margin.left = 0;
      LinkLabelStyle.margin.right = 0;
    }

    public static readonly GUIStyle LinkLabelStyle;
  }
=======
using UnityEditor;
using UnityEngine;

namespace Packages.Rider.Editor
{
  internal static class RiderStyles
  {
    static RiderStyles()
    {
      LinkLabelStyle = new GUIStyle(EditorStyles.linkLabel)
      {
        padding = GUI.skin.label.padding,
        margin = GUI.skin.label.margin
      };
      LinkLabelStyle.padding.left = 0;
      LinkLabelStyle.padding.right = 0;
      LinkLabelStyle.margin.left = 0;
      LinkLabelStyle.margin.right = 0;
    }

    public static readonly GUIStyle LinkLabelStyle;
  }
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
}