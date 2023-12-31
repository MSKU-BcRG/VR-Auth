<<<<<<< HEAD
namespace UnityEngine.XR.Interaction.Toolkit
{
    /// <summary>
    /// An interface that allows Interactables to request that an Interactor use a custom reticle.
    /// </summary>
    public interface IXRCustomReticleProvider
    {
        /// <summary>
        /// Attaches a custom reticle.
        /// </summary>
        /// <param name="reticleInstance">Reticle GameObject that is attached.</param>
        /// <returns>Returns <see langword="true"/> if successful. Otherwise, returns <see langword="false"/>.</returns>
        bool AttachCustomReticle(GameObject reticleInstance);

        /// <summary>
        /// Removes a custom reticle.
        /// </summary>
        /// <returns>Returns <see langword="true"/> if successful. Otherwise, returns <see langword="false"/>.</returns>
        bool RemoveCustomReticle();
    }
}
=======
namespace UnityEngine.XR.Interaction.Toolkit
{
    /// <summary>
    /// An interface that allows Interactables to request that an Interactor use a custom reticle.
    /// </summary>
    public interface IXRCustomReticleProvider
    {
        /// <summary>
        /// Attaches a custom reticle.
        /// </summary>
        /// <param name="reticleInstance">Reticle GameObject that is attached.</param>
        /// <returns>Returns <see langword="true"/> if successful. Otherwise, returns <see langword="false"/>.</returns>
        bool AttachCustomReticle(GameObject reticleInstance);

        /// <summary>
        /// Removes a custom reticle.
        /// </summary>
        /// <returns>Returns <see langword="true"/> if successful. Otherwise, returns <see langword="false"/>.</returns>
        bool RemoveCustomReticle();
    }
}
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
