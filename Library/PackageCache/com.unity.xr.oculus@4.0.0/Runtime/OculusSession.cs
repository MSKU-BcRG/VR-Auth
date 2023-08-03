<<<<<<< HEAD
using UnityEngine;

namespace Unity.XR.Oculus
{
    internal static class OculusSession
    {
        public static void Update()
        {
            if (NativeMethods.GetShouldRestartSession()) {
                OculusRestarter.Instance.PauseAndRestart();
            }
        }
    }
=======
using UnityEngine;

namespace Unity.XR.Oculus
{
    internal static class OculusSession
    {
        public static void Update()
        {
            if (NativeMethods.GetShouldRestartSession()) {
                OculusRestarter.Instance.PauseAndRestart();
            }
        }
    }
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
}