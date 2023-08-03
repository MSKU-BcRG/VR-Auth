<<<<<<< HEAD
using UnityEngine;

namespace Unity.AI.Navigation.Samples
{
    /// <summary>
    /// Destroy owning GameObject if any collider with a specific tag is trespassing
    /// </summary>
    public class DestroyOnTrigger : MonoBehaviour
    {
        public string m_Tag = "Player";

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == m_Tag)
                Destroy(gameObject);
        }
    }
=======
using UnityEngine;

namespace Unity.AI.Navigation.Samples
{
    /// <summary>
    /// Destroy owning GameObject if any collider with a specific tag is trespassing
    /// </summary>
    public class DestroyOnTrigger : MonoBehaviour
    {
        public string m_Tag = "Player";

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == m_Tag)
                Destroy(gameObject);
        }
    }
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
}