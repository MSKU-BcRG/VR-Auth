<<<<<<< HEAD
﻿using System.IO;

namespace Rider.Editor.Util
{
  internal static class RiderPathUtil
  {
    public static bool IsRiderDevEditor(string editorPath)
    {
      if (editorPath == null)
        return false;
      return "rider-dev".Equals(Path.GetFileNameWithoutExtension(editorPath));
    }
  }
=======
﻿using System.IO;

namespace Rider.Editor.Util
{
  internal static class RiderPathUtil
  {
    public static bool IsRiderDevEditor(string editorPath)
    {
      if (editorPath == null)
        return false;
      return "rider-dev".Equals(Path.GetFileNameWithoutExtension(editorPath));
    }
  }
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
}