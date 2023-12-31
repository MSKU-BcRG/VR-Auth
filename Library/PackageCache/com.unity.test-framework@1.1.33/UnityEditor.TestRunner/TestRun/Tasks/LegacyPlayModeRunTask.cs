<<<<<<< HEAD
using System.Collections;
using System.Linq;
using UnityEngine.TestTools.TestRunner;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class LegacyPlayModeRunTask : TestTaskBase
    {
        public LegacyPlayModeRunTask() : base(true)
        {
            
        }
        public override IEnumerator Execute(TestJobData testJobData)
        {
            var settings = PlaymodeTestsControllerSettings.CreateRunnerSettings(testJobData.executionSettings.filters.Select(filter => filter.ToRuntimeTestRunnerFilter(testJobData.executionSettings.runSynchronously)).ToArray(), testJobData.executionSettings.orderedTestNames);
            var launcher = new PlaymodeLauncher(settings);
            
            launcher.Run();

            while (PlaymodeLauncher.IsRunning)
            {
                yield return null;
            }
        }
    }
=======
using System.Collections;
using System.Linq;
using UnityEngine.TestTools.TestRunner;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class LegacyPlayModeRunTask : TestTaskBase
    {
        public LegacyPlayModeRunTask() : base(true)
        {
            
        }
        public override IEnumerator Execute(TestJobData testJobData)
        {
            var settings = PlaymodeTestsControllerSettings.CreateRunnerSettings(testJobData.executionSettings.filters.Select(filter => filter.ToRuntimeTestRunnerFilter(testJobData.executionSettings.runSynchronously)).ToArray(), testJobData.executionSettings.orderedTestNames);
            var launcher = new PlaymodeLauncher(settings);
            
            launcher.Run();

            while (PlaymodeLauncher.IsRunning)
            {
                yield return null;
            }
        }
    }
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
}