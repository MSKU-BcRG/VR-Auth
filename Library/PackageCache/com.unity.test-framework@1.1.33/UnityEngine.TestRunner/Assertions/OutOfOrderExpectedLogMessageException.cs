<<<<<<< HEAD
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using UnityEngine.TestTools.Logging;

namespace UnityEngine.TestTools.TestRunner
{
    internal class OutOfOrderExpectedLogMessageException : ResultStateException
    {
        public OutOfOrderExpectedLogMessageException(LogEvent log, LogMatch nextExpected)
            : base(BuildMessage(log, nextExpected))
        {
        }

        private static string BuildMessage(LogEvent log, LogMatch nextExpected)
        {
            return $"Expected {log.LogType} with '{log.Message}' arrived out of order. Expected {nextExpected.LogType} with '{nextExpected.Message}' next.";
        }

        public override ResultState ResultState
        {
            get { return ResultState.Failure; }
        }

        public override string StackTrace { get { return null; } }
    }
}
=======
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using UnityEngine.TestTools.Logging;

namespace UnityEngine.TestTools.TestRunner
{
    internal class OutOfOrderExpectedLogMessageException : ResultStateException
    {
        public OutOfOrderExpectedLogMessageException(LogEvent log, LogMatch nextExpected)
            : base(BuildMessage(log, nextExpected))
        {
        }

        private static string BuildMessage(LogEvent log, LogMatch nextExpected)
        {
            return $"Expected {log.LogType} with '{log.Message}' arrived out of order. Expected {nextExpected.LogType} with '{nextExpected.Message}' next.";
        }

        public override ResultState ResultState
        {
            get { return ResultState.Failure; }
        }

        public override string StackTrace { get { return null; } }
    }
}
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
