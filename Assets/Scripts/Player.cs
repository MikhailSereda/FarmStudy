using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace Golf
{
        public class Player : MonoBehaviour
    {
        public Transform stick;
        private bool m_IsDown = false;

        public float range = 40f;
        public float speed = 500f;
        public float power = 20f;

        private void Update()
        {
         m_IsDown = Input.GetMouseButton(0);

         Quaternion rot = stick.localRotation;
         Quaternion toRot = Quaternion.Euler(0,0, m_IsDown ? range: - range);
         rot = Quaternion.RotateTowards(rot, toRot, speed * Time.deltaTime);
         stick.localRotation = rot;
        }
        public void OnCillisionStick(Collider collider)
        {
            if(collider.TryGetComponent(out Rigidbody stone))
            {
                var dir = m_IsDown ? stick.right : -stick.right;
                stone.AddForce(dir * power, ForceMode.Impulse);
            }

            Debug.Log(collider, this);
        }

    }
}