<<<<<<< HEAD
using System.Collections;
using System.Linq;
using System.Reflection;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;

namespace UnityEngine.TestTools.TestRunner.GUI
{
    class SynchronousFilter : ITestFilter
    {
        public TNode ToXml(bool recursive)
        {
            return new TNode("synchronousOnly");
        }

        public TNode AddToXml(TNode parentNode, bool recursive)
        {
            return parentNode.AddElement("synchronousOnly");
        }

        public bool Pass(ITest test)
        {
            if (test.Method == null)
                return true;
            
            if (test.Method.ReturnType.Type == typeof(IEnumerator))
                return false;

            if (test.Method.GetCustomAttributes<IOuterUnityTestAction>(true).Any())
                return false;

            if (test.TypeInfo?.Type != null)
            {
                if (Reflect.GetMethodsWithAttribute(test.TypeInfo.Type, typeof(UnitySetUpAttribute), true)
                    .Any(mi => mi.ReturnType == typeof(System.Collections.IEnumerator)))
                    return false;

                if (Reflect.GetMethodsWithAttribute(test.TypeInfo.Type, typeof(UnityTearDownAttribute), true)
                    .Any(mi => mi.ReturnType == typeof(System.Collections.IEnumerator)))
                    return false;
            }

            return true;
        }

        public bool IsExplicitMatch(ITest test)
        {
            return Pass(test);
        }
    }
=======
using System.Collections;
using System.Linq;
using System.Reflection;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;

namespace UnityEngine.TestTools.TestRunner.GUI
{
    class SynchronousFilter : ITestFilter
    {
        public TNode ToXml(bool recursive)
        {
            return new TNode("synchronousOnly");
        }

        public TNode AddToXml(TNode parentNode, bool recursive)
        {
            return parentNode.AddElement("synchronousOnly");
        }

        public bool Pass(ITest test)
        {
            if (test.Method == null)
                return true;
            
            if (test.Method.ReturnType.Type == typeof(IEnumerator))
                return false;

            if (test.Method.GetCustomAttributes<IOuterUnityTestAction>(true).Any())
                return false;

            if (test.TypeInfo?.Type != null)
            {
                if (Reflect.GetMethodsWithAttribute(test.TypeInfo.Type, typeof(UnitySetUpAttribute), true)
                    .Any(mi => mi.ReturnType == typeof(System.Collections.IEnumerator)))
                    return false;

                if (Reflect.GetMethodsWithAttribute(test.TypeInfo.Type, typeof(UnityTearDownAttribute), true)
                    .Any(mi => mi.ReturnType == typeof(System.Collections.IEnumerator)))
                    return false;
            }

            return true;
        }

        public bool IsExplicitMatch(ITest test)
        {
            return Pass(test);
        }
    }
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
}