<<<<<<< HEAD
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestTools.TestRunner.Callbacks
{
    internal class TestResultRendererCallback : MonoBehaviour, ITestRunnerListener
    {
        private TestResultRenderer m_ResultRenderer;
        public void RunStarted(ITest testsToRun)
        {
        }

        public void RunFinished(ITestResult testResults)
        {
            if (Camera.main == null)
            {
                gameObject.AddComponent<Camera>();
            }
            m_ResultRenderer = new TestResultRenderer(testResults);
            m_ResultRenderer.ShowResults();
        }

        public void OnGUI()
        {
            if (m_ResultRenderer != null)
                m_ResultRenderer.Draw();
        }

        public void TestStarted(ITest test)
        {
        }

        public void TestFinished(ITestResult result)
        {
        }
    }
}
=======
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestTools.TestRunner.Callbacks
{
    internal class TestResultRendererCallback : MonoBehaviour, ITestRunnerListener
    {
        private TestResultRenderer m_ResultRenderer;
        public void RunStarted(ITest testsToRun)
        {
        }

        public void RunFinished(ITestResult testResults)
        {
            if (Camera.main == null)
            {
                gameObject.AddComponent<Camera>();
            }
            m_ResultRenderer = new TestResultRenderer(testResults);
            m_ResultRenderer.ShowResults();
        }

        public void OnGUI()
        {
            if (m_ResultRenderer != null)
                m_ResultRenderer.Draw();
        }

        public void TestStarted(ITest test)
        {
        }

        public void TestFinished(ITestResult result)
        {
        }
    }
}
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
