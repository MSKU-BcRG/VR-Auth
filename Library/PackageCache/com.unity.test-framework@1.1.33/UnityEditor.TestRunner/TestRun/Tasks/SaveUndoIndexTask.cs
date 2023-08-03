<<<<<<< HEAD
using System;
using System.Collections;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class SaveUndoIndexTask : TestTaskBase
    {
        internal Func<int> GetUndoGroup = Undo.GetCurrentGroup;
        public override IEnumerator Execute(TestJobData testJobData)
        {
            testJobData.undoGroup = GetUndoGroup();
            yield break;
        }
    }
=======
using System;
using System.Collections;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class SaveUndoIndexTask : TestTaskBase
    {
        internal Func<int> GetUndoGroup = Undo.GetCurrentGroup;
        public override IEnumerator Execute(TestJobData testJobData)
        {
            testJobData.undoGroup = GetUndoGroup();
            yield break;
        }
    }
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
}