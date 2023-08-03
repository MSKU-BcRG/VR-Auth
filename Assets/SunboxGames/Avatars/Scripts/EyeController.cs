<<<<<<< HEAD

using UnityEngine;

namespace Sunbox.Avatars {
    public class EyeController : MonoBehaviour {

        public Transform GazeTarget;
        
        private Transform eye;

        void Awake() {
            eye = this.transform;
        }

        void Update() {

            Vector3 viewDirection = GazeTarget.position - eye.position;

            Quaternion rotation = Quaternion.LookRotation(GazeTarget.position - eye.position, Vector3.forward);
            rotation *= Quaternion.Euler(90, 0, 0);

            eye.rotation = rotation;

        }
    }
}
=======

using UnityEngine;

namespace Sunbox.Avatars {
    public class EyeController : MonoBehaviour {

        public Transform GazeTarget;
        
        private Transform eye;

        void Awake() {
            eye = this.transform;
        }

        void Update() {

            Vector3 viewDirection = GazeTarget.position - eye.position;

            Quaternion rotation = Quaternion.LookRotation(GazeTarget.position - eye.position, Vector3.forward);
            rotation *= Quaternion.Euler(90, 0, 0);

            eye.rotation = rotation;

        }
    }
}
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
