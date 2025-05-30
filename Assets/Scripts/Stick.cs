using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

namespace Golf
{
    public class Stick : MonoBehaviour
    {
        public UnityEvent<Collider> onCollision;
        private void OnCollisionEnter(Collision collision)
        {
            onCollision.Invoke(collision.collider);
        }
    }
}