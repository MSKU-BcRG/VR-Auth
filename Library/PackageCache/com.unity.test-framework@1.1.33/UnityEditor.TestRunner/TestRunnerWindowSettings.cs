<<<<<<< HEAD
namespace UnityEditor.TestTools.TestRunner
{
    internal class TestRunnerWindowSettings
    {
        public bool verticalSplit;

        private readonly string m_PrefsKey;

        public TestRunnerWindowSettings(string prefsKey)
        {
            m_PrefsKey = prefsKey;
            verticalSplit = EditorPrefs.GetBool(m_PrefsKey + ".verticalSplit", true);
        }

        public void ToggleVerticalSplit()
        {
            verticalSplit = !verticalSplit;
            Save();
        }

        private void Save()
        {
            EditorPrefs.SetBool(m_PrefsKey + ".verticalSplit", verticalSplit);
        }
    }
}
=======
namespace UnityEditor.TestTools.TestRunner
{
    internal class TestRunnerWindowSettings
    {
        public bool verticalSplit;

        private readonly string m_PrefsKey;

        public TestRunnerWindowSettings(string prefsKey)
        {
            m_PrefsKey = prefsKey;
            verticalSplit = EditorPrefs.GetBool(m_PrefsKey + ".verticalSplit", true);
        }

        public void ToggleVerticalSplit()
        {
            verticalSplit = !verticalSplit;
            Save();
        }

        private void Save()
        {
            EditorPrefs.SetBool(m_PrefsKey + ".verticalSplit", verticalSplit);
        }
    }
}
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
