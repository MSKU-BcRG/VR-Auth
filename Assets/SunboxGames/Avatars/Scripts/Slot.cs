<<<<<<< HEAD

using UnityEngine;

namespace Sunbox.Avatars {

    public class Slot : MonoBehaviour {
        public SlotType SlotType;
        public AttachmentType AttachmentType;
        public Transform BoneTransform;

        void Awake() {
            BoneTransform = GetComponent<Transform>();
        }
        
    }

=======

using UnityEngine;

namespace Sunbox.Avatars {

    public class Slot : MonoBehaviour {
        public SlotType SlotType;
        public AttachmentType AttachmentType;
        public Transform BoneTransform;

        void Awake() {
            BoneTransform = GetComponent<Transform>();
        }
        
    }

>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
}