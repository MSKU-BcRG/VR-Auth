<<<<<<< HEAD
using System;
using System.Reflection;

namespace UnityEngine.TestTools.Utils
{
    internal class AssemblyWrapper : IAssemblyWrapper
    {
        public AssemblyWrapper(Assembly assembly)
        {
            Assembly = assembly;
            Name = assembly.GetName();
        }

        public Assembly Assembly { get; }

        public AssemblyName Name { get; }

        public virtual string Location
        {
            get
            {
                //Some platforms dont support this
                throw new NotImplementedException();
            }
        }

        public virtual AssemblyName[] GetReferencedAssemblies()
        {
            //Some platforms dont support this
            throw new NotImplementedException();
        }
    }
}
=======
using System;
using System.Reflection;

namespace UnityEngine.TestTools.Utils
{
    internal class AssemblyWrapper : IAssemblyWrapper
    {
        public AssemblyWrapper(Assembly assembly)
        {
            Assembly = assembly;
            Name = assembly.GetName();
        }

        public Assembly Assembly { get; }

        public AssemblyName Name { get; }

        public virtual string Location
        {
            get
            {
                //Some platforms dont support this
                throw new NotImplementedException();
            }
        }

        public virtual AssemblyName[] GetReferencedAssemblies()
        {
            //Some platforms dont support this
            throw new NotImplementedException();
        }
    }
}
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
