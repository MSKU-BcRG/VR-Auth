<<<<<<< HEAD
using System.IO;

namespace Packages.Rider.Editor.Util
{
  internal static class StringUtils
  {
    public static string NormalizePath(this string path)
    {
      return path.Replace(Path.DirectorySeparatorChar == '\\'
        ? '/'
        : '\\', Path.DirectorySeparatorChar);
    }
  }
=======
using System.IO;

namespace Packages.Rider.Editor.Util
{
  internal static class StringUtils
  {
    public static string NormalizePath(this string path)
    {
      return path.Replace(Path.DirectorySeparatorChar == '\\'
        ? '/'
        : '\\', Path.DirectorySeparatorChar);
    }
  }
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
}