<<<<<<< HEAD
using System;
using System.Collections;
using NUnit.Framework.Interfaces;
using UnityEngine;
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class PrebuildSetupTask : BuildActionTaskBase<IPrebuildSetup>
    {
        public PrebuildSetupTask() : base(new PrebuildSetupAttributeFinder())
        {
        }

        protected override void Action(IPrebuildSetup target)
        {
            target.Setup();
        }
    }
=======
using System;
using System.Collections;
using NUnit.Framework.Interfaces;
using UnityEngine;
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class PrebuildSetupTask : BuildActionTaskBase<IPrebuildSetup>
    {
        public PrebuildSetupTask() : base(new PrebuildSetupAttributeFinder())
        {
        }

        protected override void Action(IPrebuildSetup target)
        {
            target.Setup();
        }
    }
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
}