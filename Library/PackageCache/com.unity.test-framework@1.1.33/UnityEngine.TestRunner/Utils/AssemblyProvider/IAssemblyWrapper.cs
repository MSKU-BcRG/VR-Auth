<<<<<<< HEAD
using System.Reflection;

namespace UnityEngine.TestTools.Utils
{
    internal interface IAssemblyWrapper
    {
        Assembly Assembly { get; }
        AssemblyName Name { get; }
        string Location { get; }
        AssemblyName[] GetReferencedAssemblies();
    }
}
=======
using System.Reflection;

namespace UnityEngine.TestTools.Utils
{
    internal interface IAssemblyWrapper
    {
        Assembly Assembly { get; }
        AssemblyName Name { get; }
        string Location { get; }
        AssemblyName[] GetReferencedAssemblies();
    }
}
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
