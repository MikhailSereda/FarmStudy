using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TZ
{
    public class BigStoneSpawner : MonoBehaviour
    {
        public GameObject prefab;
        public void Spawn()
        {
            Debug.Log("spawn");
            if (prefab == null)
            {
                Debug.LogError("Spawner - prefab == 0");
                return;
            }
            Instantiate(prefab, transform.position, Quaternion.identity);
        }
    }
}

