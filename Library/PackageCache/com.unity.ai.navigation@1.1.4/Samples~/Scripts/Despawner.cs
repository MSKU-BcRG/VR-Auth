<<<<<<< HEAD
using System;
using UnityEngine;

namespace Unity.AI.Navigation.Samples
{
    /// <summary>
    /// Destroy GameObjects upon collision
    /// </summary>
    [RequireComponent(typeof(Collider))]
    public class Despawner : MonoBehaviour
    {
        void OnCollisionEnter(Collision collision)
        {
            Destroy(collision.gameObject);
        }
    }
}
=======
using System;
using UnityEngine;

namespace Unity.AI.Navigation.Samples
{
    /// <summary>
    /// Destroy GameObjects upon collision
    /// </summary>
    [RequireComponent(typeof(Collider))]
    public class Despawner : MonoBehaviour
    {
        void OnCollisionEnter(Collision collision)
        {
            Destroy(collision.gameObject);
        }
    }
}
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
