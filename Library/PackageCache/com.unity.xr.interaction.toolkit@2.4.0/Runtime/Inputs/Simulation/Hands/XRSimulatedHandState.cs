<<<<<<< HEAD
namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.Hands
{
    struct XRSimulatedHandState
    {
        public Vector3 position { get; set; }
        public Quaternion rotation { get; set; }
        public Vector3 euler { get; set; }
        public HandExpressionName expressionName { get; set; }

        /// <summary>
        /// Resets the value of all fields to default or the identity rotation.
        /// </summary>
        public void Reset()
        {
            position = default;
            rotation = Quaternion.identity;
            euler = default;
            expressionName = HandExpressionName.Default;
        }
    }
}
=======
namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.Hands
{
    struct XRSimulatedHandState
    {
        public Vector3 position { get; set; }
        public Quaternion rotation { get; set; }
        public Vector3 euler { get; set; }
        public HandExpressionName expressionName { get; set; }

        /// <summary>
        /// Resets the value of all fields to default or the identity rotation.
        /// </summary>
        public void Reset()
        {
            position = default;
            rotation = Quaternion.identity;
            euler = default;
            expressionName = HandExpressionName.Default;
        }
    }
}
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
