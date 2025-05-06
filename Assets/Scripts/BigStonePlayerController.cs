using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TZ
{
    public class BigStonePlayerController : MonoBehaviour
    {
        public BigStoneSpawner spawner;
        public CloudController cloudcontroller;
        public List <Refresh> villagers;
        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.X))
            {
                Debug.Log("X Key down");
                spawner.Spawn();
            }

            if(Input.GetKeyDown(KeyCode.Z))
            {
                Debug.Log("Z Key down");
                cloudcontroller.Action();
            }

            if(Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Space Key down");
                foreach (var villager in villagers)
                {
                    villager.ChangeTool();
                }
            }
        }        
    }
}