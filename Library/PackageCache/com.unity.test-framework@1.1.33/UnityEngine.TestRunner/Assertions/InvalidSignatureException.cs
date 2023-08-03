<<<<<<< HEAD
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestTools.TestRunner
{
    internal class InvalidSignatureException : ResultStateException
    {
        public InvalidSignatureException(string message)
            : base(message)
        {
        }

        public override ResultState ResultState
        {
            get { return ResultState.NotRunnable; }
        }
    }
}
=======
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestTools.TestRunner
{
    internal class InvalidSignatureException : ResultStateException
    {
        public InvalidSignatureException(string message)
            : base(message)
        {
        }

        public override ResultState ResultState
        {
            get { return ResultState.NotRunnable; }
        }
    }
}
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
