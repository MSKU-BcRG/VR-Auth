<<<<<<< HEAD
using System;
using Unity.XR.CoreUtils.Datums;

namespace UnityEngine.XR.Interaction.Toolkit.Filtering
{
    /// <summary>
    /// Serializable container class that holds a poke threshold value or container asset reference.
    /// </summary>
    /// <seealso cref="PokeThresholdDatum"/>
    [Serializable]
    public class PokeThresholdDatumProperty : DatumProperty<PokeThresholdData, PokeThresholdDatum>
    {
        /// <inheritdoc/>
        public PokeThresholdDatumProperty(PokeThresholdData value) : base(value)
        {
        }

        /// <inheritdoc/>
        public PokeThresholdDatumProperty(PokeThresholdDatum datum) : base(datum)
        {
        }
    }
=======
using System;
using Unity.XR.CoreUtils.Datums;

namespace UnityEngine.XR.Interaction.Toolkit.Filtering
{
    /// <summary>
    /// Serializable container class that holds a poke threshold value or container asset reference.
    /// </summary>
    /// <seealso cref="PokeThresholdDatum"/>
    [Serializable]
    public class PokeThresholdDatumProperty : DatumProperty<PokeThresholdData, PokeThresholdDatum>
    {
        /// <inheritdoc/>
        public PokeThresholdDatumProperty(PokeThresholdData value) : base(value)
        {
        }

        /// <inheritdoc/>
        public PokeThresholdDatumProperty(PokeThresholdDatum datum) : base(datum)
        {
        }
    }
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
}