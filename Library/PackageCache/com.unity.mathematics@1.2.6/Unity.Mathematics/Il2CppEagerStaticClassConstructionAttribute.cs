<<<<<<< HEAD
using System;

namespace Unity.IL2CPP.CompilerServices
{
    /// <summary>
    /// This is used to indicate to IL2CPP that the static constructors should be executed eagerly at startup
    /// rather than lazily at runtime.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false, AllowMultiple = false)]
    internal class Il2CppEagerStaticClassConstructionAttribute : Attribute
    {
    }
=======
using System;

namespace Unity.IL2CPP.CompilerServices
{
    /// <summary>
    /// This is used to indicate to IL2CPP that the static constructors should be executed eagerly at startup
    /// rather than lazily at runtime.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false, AllowMultiple = false)]
    internal class Il2CppEagerStaticClassConstructionAttribute : Attribute
    {
    }
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
}