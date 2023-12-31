<<<<<<< HEAD
namespace UnityEditor.TestTools.TestRunner
{
    internal class DelayedCallback
    {
        private System.Action m_Callback;
        private double m_CallbackTime;
        private double m_Delay;

        public DelayedCallback(System.Action function, double timeFromNow)
        {
            m_Callback = function;
            m_CallbackTime = EditorApplication.timeSinceStartup + timeFromNow;
            m_Delay = timeFromNow;
            EditorApplication.update += Update;
        }

        public void Clear()
        {
            EditorApplication.update -= Update;
            m_CallbackTime = 0.0;
            m_Callback = null;
        }

        private void Update()
        {
            if (EditorApplication.timeSinceStartup > m_CallbackTime)
            {
                // Clear state before firing callback to ensure reset (callback could call ExitGUI)
                var callback = m_Callback;
                Clear();

                callback?.Invoke();
            }
        }

        public void Reset()
        {
            if (m_Callback != null)
            {
                m_CallbackTime = EditorApplication.timeSinceStartup + m_Delay;
            }
        }
    }
=======
namespace UnityEditor.TestTools.TestRunner
{
    internal class DelayedCallback
    {
        private System.Action m_Callback;
        private double m_CallbackTime;
        private double m_Delay;

        public DelayedCallback(System.Action function, double timeFromNow)
        {
            m_Callback = function;
            m_CallbackTime = EditorApplication.timeSinceStartup + timeFromNow;
            m_Delay = timeFromNow;
            EditorApplication.update += Update;
        }

        public void Clear()
        {
            EditorApplication.update -= Update;
            m_CallbackTime = 0.0;
            m_Callback = null;
        }

        private void Update()
        {
            if (EditorApplication.timeSinceStartup > m_CallbackTime)
            {
                // Clear state before firing callback to ensure reset (callback could call ExitGUI)
                var callback = m_Callback;
                Clear();

                callback?.Invoke();
            }
        }

        public void Reset()
        {
            if (m_Callback != null)
            {
                m_CallbackTime = EditorApplication.timeSinceStartup + m_Delay;
            }
        }
    }
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
}