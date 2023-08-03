<<<<<<< HEAD
using System;

namespace UnityEditor.TestTools.TestRunner.CommandLineTest
{
    internal class SetupException : Exception
    {
        public ExceptionType Type { get; }
        public object[] Details { get; }

        public SetupException(ExceptionType type, params object[] details)
        {
            Type = type;
            Details = details;
        }

        public enum ExceptionType
        {
            ScriptCompilationFailed,
            PlatformNotFound,
            TestSettingsFileNotFound,
            OrderedTestListFileNotFound,
        }
    }
}
=======
using System;

namespace UnityEditor.TestTools.TestRunner.CommandLineTest
{
    internal class SetupException : Exception
    {
        public ExceptionType Type { get; }
        public object[] Details { get; }

        public SetupException(ExceptionType type, params object[] details)
        {
            Type = type;
            Details = details;
        }

        public enum ExceptionType
        {
            ScriptCompilationFailed,
            PlatformNotFound,
            TestSettingsFileNotFound,
            OrderedTestListFileNotFound,
        }
    }
}
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
