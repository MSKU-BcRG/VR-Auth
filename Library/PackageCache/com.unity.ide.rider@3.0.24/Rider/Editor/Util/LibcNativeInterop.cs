<<<<<<< HEAD
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Packages.Rider.Editor.Util
{
  internal static class LibcNativeInterop
  {
    [DllImport("libc", SetLastError = true)] 
    public static extern IntPtr realpath(string path, StringBuilder resolved_path);
  }
=======
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Packages.Rider.Editor.Util
{
  internal static class LibcNativeInterop
  {
    [DllImport("libc", SetLastError = true)] 
    public static extern IntPtr realpath(string path, StringBuilder resolved_path);
  }
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
}