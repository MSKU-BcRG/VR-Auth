<<<<<<< HEAD
using System.Collections;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class RegisterFilesForCleanupVerificationTask : FileCleanupVerifierTaskBase
    {
        public override IEnumerator Execute(TestJobData testJobData)
        {
            testJobData.existingFiles = GetAllFilesInAssetsDirectory();
            yield return null;
        }
    }
=======
using System.Collections;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class RegisterFilesForCleanupVerificationTask : FileCleanupVerifierTaskBase
    {
        public override IEnumerator Execute(TestJobData testJobData)
        {
            testJobData.existingFiles = GetAllFilesInAssetsDirectory();
            yield return null;
        }
    }
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
}