<<<<<<< HEAD
using System;

namespace UnityEngine.XR.Interaction.Toolkit.Filtering
{
    /// <summary>
    /// Holds information used for poke interaction affordances.
    /// </summary>
    public struct PokeStateData : IEquatable<PokeStateData>
    {
        /// <summary>
        /// Signifies whether the current event meets requirements for poking.
        /// </summary>
        public bool meetsRequirements { get; set; }

        /// <summary>
        /// The <see cref="Vector3"/> point where the current interaction is being evaluated.
        /// </summary>
        public Vector3 pokeInteractionPoint { get; set; }

        /// <summary>
        /// The <see cref="Vector3"/> point along the axis of interaction based on the <see cref="pokeInteractionPoint"/>,
        /// current poke depth, normal vector to the axis of interaction, and the offset based on the <see cref="PokeThresholdData.interactionDepthOffset"/>.
        /// </summary>
        public Vector3 axisAlignedPokeInteractionPoint { get; set; }

        /// <summary>
        /// The amount the poke interaction is currently selecting the interactable between 0 and 1.
        /// </summary>
        public float interactionStrength { get; set; }

        /// <summary>
        /// This is the current target hit by the <see cref="XRPokeInteractor"/> that this state data is relevant for.
        /// </summary>
        public Transform target { get; set; }

        /// <inheritdoc />
        public bool Equals(PokeStateData other)
        {
            return meetsRequirements == other.meetsRequirements &&
                pokeInteractionPoint.Equals(other.pokeInteractionPoint) &&
                axisAlignedPokeInteractionPoint.Equals(other.axisAlignedPokeInteractionPoint) &&
                interactionStrength.Equals(other.interactionStrength) &&
                (target == other.target);
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            return obj is PokeStateData other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            var hash = 17;
            hash = hash * 31 + meetsRequirements.GetHashCode();
            hash = hash * 31 + pokeInteractionPoint.GetHashCode();
            hash = hash * 31 + axisAlignedPokeInteractionPoint.GetHashCode();
            hash = hash * 31 + interactionStrength.GetHashCode();
            hash = hash * 31 + target.GetHashCode();
            return hash;
        }
    }
}
=======
using System;

namespace UnityEngine.XR.Interaction.Toolkit.Filtering
{
    /// <summary>
    /// Holds information used for poke interaction affordances.
    /// </summary>
    public struct PokeStateData : IEquatable<PokeStateData>
    {
        /// <summary>
        /// Signifies whether the current event meets requirements for poking.
        /// </summary>
        public bool meetsRequirements { get; set; }

        /// <summary>
        /// The <see cref="Vector3"/> point where the current interaction is being evaluated.
        /// </summary>
        public Vector3 pokeInteractionPoint { get; set; }

        /// <summary>
        /// The <see cref="Vector3"/> point along the axis of interaction based on the <see cref="pokeInteractionPoint"/>,
        /// current poke depth, normal vector to the axis of interaction, and the offset based on the <see cref="PokeThresholdData.interactionDepthOffset"/>.
        /// </summary>
        public Vector3 axisAlignedPokeInteractionPoint { get; set; }

        /// <summary>
        /// The amount the poke interaction is currently selecting the interactable between 0 and 1.
        /// </summary>
        public float interactionStrength { get; set; }

        /// <summary>
        /// This is the current target hit by the <see cref="XRPokeInteractor"/> that this state data is relevant for.
        /// </summary>
        public Transform target { get; set; }

        /// <inheritdoc />
        public bool Equals(PokeStateData other)
        {
            return meetsRequirements == other.meetsRequirements &&
                pokeInteractionPoint.Equals(other.pokeInteractionPoint) &&
                axisAlignedPokeInteractionPoint.Equals(other.axisAlignedPokeInteractionPoint) &&
                interactionStrength.Equals(other.interactionStrength) &&
                (target == other.target);
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            return obj is PokeStateData other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            var hash = 17;
            hash = hash * 31 + meetsRequirements.GetHashCode();
            hash = hash * 31 + pokeInteractionPoint.GetHashCode();
            hash = hash * 31 + axisAlignedPokeInteractionPoint.GetHashCode();
            hash = hash * 31 + interactionStrength.GetHashCode();
            hash = hash * 31 + target.GetHashCode();
            return hash;
        }
    }
}
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
