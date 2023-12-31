<<<<<<< HEAD
namespace UnityEditor.TestTools.TestRunner.Api
{
    /// <summary>
    /// An extended version of the <see cref="ICallbacks"/>, which get invoked if the test run fails due to a build error or if any <see cref="UnityEngine.TestTools.IPrebuildSetup"/> has a failure.
    /// </summary>
    public interface IErrorCallbacks : ICallbacks
    {
        /// <summary>
        /// Method invoked on failure.
        /// </summary>
        /// <param name="message">
        /// The error message detailing the reason for the run to fail.
        /// </param>
        void OnError(string message);
    }
}
=======
namespace UnityEditor.TestTools.TestRunner.Api
{
    /// <summary>
    /// An extended version of the <see cref="ICallbacks"/>, which get invoked if the test run fails due to a build error or if any <see cref="UnityEngine.TestTools.IPrebuildSetup"/> has a failure.
    /// </summary>
    public interface IErrorCallbacks : ICallbacks
    {
        /// <summary>
        /// Method invoked on failure.
        /// </summary>
        /// <param name="message">
        /// The error message detailing the reason for the run to fail.
        /// </param>
        void OnError(string message);
    }
}
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
