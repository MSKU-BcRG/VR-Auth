<<<<<<< HEAD
using System.Collections;
using System.Linq;
using UnityEngine.TestTools.TestRunner;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class LegacyPlayerRunTask : TestTaskBase
    {
        public override IEnumerator Execute(TestJobData testJobData)
        {
            var executionSettings = testJobData.executionSettings;
            var settings = PlaymodeTestsControllerSettings.CreateRunnerSettings(executionSettings.filters.Select(filter => filter.ToRuntimeTestRunnerFilter(executionSettings.runSynchronously)).ToArray(), testJobData.executionSettings.orderedTestNames);
            var launcher = new PlayerLauncher(settings, executionSettings.targetPlatform, executionSettings.overloadTestRunSettings, executionSettings.playerHeartbeatTimeout, executionSettings.playerSavePath);
            launcher.Run();
            yield return null;
        }
    }
=======
using System.Collections;
using System.Linq;
using UnityEngine.TestTools.TestRunner;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class LegacyPlayerRunTask : TestTaskBase
    {
        public override IEnumerator Execute(TestJobData testJobData)
        {
            var executionSettings = testJobData.executionSettings;
            var settings = PlaymodeTestsControllerSettings.CreateRunnerSettings(executionSettings.filters.Select(filter => filter.ToRuntimeTestRunnerFilter(executionSettings.runSynchronously)).ToArray(), testJobData.executionSettings.orderedTestNames);
            var launcher = new PlayerLauncher(settings, executionSettings.targetPlatform, executionSettings.overloadTestRunSettings, executionSettings.playerHeartbeatTimeout, executionSettings.playerSavePath);
            launcher.Run();
            yield return null;
        }
    }
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
}