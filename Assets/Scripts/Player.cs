using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

namespace Golf
{
        public class Player : MonoBehaviour
    {
        public Transform stick;
        public Transform helper;

        private Vector3 m_lastPosition;
        private bool m_IsDown = false;

        public float range = 40f;
        public float speed = 500f;
        public float power = 20f;

        private void Update()
        {
            m_lastPosition = helper.position;

         
         Quaternion rot = stick.localRotation;
         Quaternion toRot = Quaternion.Euler(0,0, m_IsDown ? range: - range);
         rot = Quaternion.RotateTowards(rot, toRot, speed * Time.deltaTime);
         stick.localRotation = rot;
        }

        public void SetDown(bool value)
        {
            m_IsDown = value;
        }
        public void OnCillisionStick(Collider collider)
        {
            if(collider.TryGetComponent(out Rigidbody body))
            {
                var dir = (helper.position-m_lastPosition).normalized;
                body.AddForce(dir * power, ForceMode.Impulse);

                if(collider.TryGetComponent(out Stone stone) && !stone.isAffect)
                {
                    stone.isAffect = true;
                    GameEvents.StickHit();

                }
            }

            Debug.Log(collider, this);
        }

    }
}