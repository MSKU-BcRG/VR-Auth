<<<<<<< HEAD
﻿namespace UnityEngine.XR.Interaction.Toolkit
{
    /// <summary>
    /// An interface that provides the rotation of a reticle to match an interactor's attach transform.
    /// </summary>
    public interface IXRReticleDirectionProvider
    {
        /// <summary>
        /// Get the reticle direction based on the given interactor's attach transform.
        /// </summary>
        /// <param name="interactor">The interactor whose attach transform determines the reticle direction.</param>
        /// <param name="hitNormal">The normal of the surface the reticle is placed on. This is the default value for <paramref name="reticleUp"/> if the provider does not specify up directionality.</param>
        /// <param name="reticleUp">The returned up direction of the reticle.</param>
        /// <param name="optionalReticleForward">The returned forward direction of the reticle. This will be <see langword="null"/> if the provider does not specify forward directionality.</param>
        void GetReticleDirection(IXRInteractor interactor, Vector3 hitNormal, out Vector3 reticleUp, out Vector3? optionalReticleForward);
    }
=======
﻿namespace UnityEngine.XR.Interaction.Toolkit
{
    /// <summary>
    /// An interface that provides the rotation of a reticle to match an interactor's attach transform.
    /// </summary>
    public interface IXRReticleDirectionProvider
    {
        /// <summary>
        /// Get the reticle direction based on the given interactor's attach transform.
        /// </summary>
        /// <param name="interactor">The interactor whose attach transform determines the reticle direction.</param>
        /// <param name="hitNormal">The normal of the surface the reticle is placed on. This is the default value for <paramref name="reticleUp"/> if the provider does not specify up directionality.</param>
        /// <param name="reticleUp">The returned up direction of the reticle.</param>
        /// <param name="optionalReticleForward">The returned forward direction of the reticle. This will be <see langword="null"/> if the provider does not specify forward directionality.</param>
        void GetReticleDirection(IXRInteractor interactor, Vector3 hitNormal, out Vector3 reticleUp, out Vector3? optionalReticleForward);
    }
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
}