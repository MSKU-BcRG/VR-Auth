<<<<<<< HEAD
using System.Linq;
using UnityEditor.Build;

namespace UnityEditor.TestRunner
{
    // This class is invoked from native, during build
    internal class TestBuildAssemblyFilter : IFilterBuildAssemblies
    {
        private const string nunitAssemblyName = "nunit.framework";
        private const string unityTestRunnerAssemblyName = "UnityEngine.TestRunner";

        public int callbackOrder { get; }
        public string[] OnFilterAssemblies(BuildOptions buildOptions, string[] assemblies)
        {
            if ((buildOptions & BuildOptions.IncludeTestAssemblies) == BuildOptions.IncludeTestAssemblies || PlayerSettings.playModeTestRunnerEnabled)
            {
                return assemblies;
            }
            return assemblies.Where(x => !x.Contains(nunitAssemblyName) && !x.Contains(unityTestRunnerAssemblyName)).ToArray();
        }
    }
}
=======
using System.Linq;
using UnityEditor.Build;

namespace UnityEditor.TestRunner
{
    // This class is invoked from native, during build
    internal class TestBuildAssemblyFilter : IFilterBuildAssemblies
    {
        private const string nunitAssemblyName = "nunit.framework";
        private const string unityTestRunnerAssemblyName = "UnityEngine.TestRunner";

        public int callbackOrder { get; }
        public string[] OnFilterAssemblies(BuildOptions buildOptions, string[] assemblies)
        {
            if ((buildOptions & BuildOptions.IncludeTestAssemblies) == BuildOptions.IncludeTestAssemblies || PlayerSettings.playModeTestRunnerEnabled)
            {
                return assemblies;
            }
            return assemblies.Where(x => !x.Contains(nunitAssemblyName) && !x.Contains(unityTestRunnerAssemblyName)).ToArray();
        }
    }
}
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
