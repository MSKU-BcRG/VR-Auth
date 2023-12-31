<<<<<<< HEAD
using System;

namespace UnityEditor.TestTools.TestRunner
{
    internal interface ITestSettings : IDisposable
    {
        ScriptingImplementation? scriptingBackend { get; set; }

        string Architecture { get; set; }

        ApiCompatibilityLevel? apiProfile { get; set; }

        bool? appleEnableAutomaticSigning { get; set; }
        string appleDeveloperTeamID { get; set; }
        ProvisioningProfileType? iOSManualProvisioningProfileType { get; set; }
        string iOSManualProvisioningProfileID { get; set; }
        ProvisioningProfileType? tvOSManualProvisioningProfileType { get; set; }
        string tvOSManualProvisioningProfileID { get; set; }
        string[] playerGraphicsAPIs { get; set; }
        bool autoGraphicsAPIs { get; set; }
        bool? androidBuildAppBundle { get; set; }

        void SetupProjectParameters();
    }
}
=======
using System;

namespace UnityEditor.TestTools.TestRunner
{
    internal interface ITestSettings : IDisposable
    {
        ScriptingImplementation? scriptingBackend { get; set; }

        string Architecture { get; set; }

        ApiCompatibilityLevel? apiProfile { get; set; }

        bool? appleEnableAutomaticSigning { get; set; }
        string appleDeveloperTeamID { get; set; }
        ProvisioningProfileType? iOSManualProvisioningProfileType { get; set; }
        string iOSManualProvisioningProfileID { get; set; }
        ProvisioningProfileType? tvOSManualProvisioningProfileType { get; set; }
        string tvOSManualProvisioningProfileID { get; set; }
        string[] playerGraphicsAPIs { get; set; }
        bool autoGraphicsAPIs { get; set; }
        bool? androidBuildAppBundle { get; set; }

        void SetupProjectParameters();
    }
}
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
