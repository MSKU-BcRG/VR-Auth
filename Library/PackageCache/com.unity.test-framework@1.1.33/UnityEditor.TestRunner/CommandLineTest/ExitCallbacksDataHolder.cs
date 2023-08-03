<<<<<<< HEAD
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.CommandLineTest
{
    internal class ExitCallbacksDataHolder : ScriptableSingleton<ExitCallbacksDataHolder>
    {
        [SerializeField] 
        public bool AnyTestsExecuted;
        [SerializeField]
        public bool RunFailed;
    }
=======
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.CommandLineTest
{
    internal class ExitCallbacksDataHolder : ScriptableSingleton<ExitCallbacksDataHolder>
    {
        [SerializeField] 
        public bool AnyTestsExecuted;
        [SerializeField]
        public bool RunFailed;
    }
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
}