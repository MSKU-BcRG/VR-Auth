<<<<<<< HEAD
using System;
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestRunner.TestLaunchers
{
    internal interface IRemoteTestResultDataFactory
    {
        RemoteTestResultDataWithTestData CreateFromTestResult(ITestResult result);
        RemoteTestResultDataWithTestData CreateFromTest(ITest test);
    }
}
=======
using System;
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestRunner.TestLaunchers
{
    internal interface IRemoteTestResultDataFactory
    {
        RemoteTestResultDataWithTestData CreateFromTestResult(ITestResult result);
        RemoteTestResultDataWithTestData CreateFromTest(ITest test);
    }
}
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
