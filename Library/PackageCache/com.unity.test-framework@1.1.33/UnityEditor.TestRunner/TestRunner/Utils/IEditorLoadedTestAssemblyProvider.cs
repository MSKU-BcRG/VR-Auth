<<<<<<< HEAD
using System.Collections.Generic;
using UnityEngine.TestTools;
using UnityEngine.TestTools.Utils;

namespace UnityEditor.TestTools.TestRunner
{
    internal interface IEditorLoadedTestAssemblyProvider
    {
        List<IAssemblyWrapper> GetAssembliesGroupedByType(TestPlatform mode);
        IEnumerator<IDictionary<TestPlatform, List<IAssemblyWrapper>>> GetAssembliesGroupedByTypeAsync(TestPlatform mode);
    }
=======
using System.Collections.Generic;
using UnityEngine.TestTools;
using UnityEngine.TestTools.Utils;

namespace UnityEditor.TestTools.TestRunner
{
    internal interface IEditorLoadedTestAssemblyProvider
    {
        List<IAssemblyWrapper> GetAssembliesGroupedByType(TestPlatform mode);
        IEnumerator<IDictionary<TestPlatform, List<IAssemblyWrapper>>> GetAssembliesGroupedByTypeAsync(TestPlatform mode);
    }
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
}