using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Golf
{
    public class Spawner : MonoBehaviour
    {
       public GameObject[] prefab;

       public void Spawn()
       {
            var prefab = GetRandomPrefab();

            if(prefab == null)
            {
                return;
            }
            Instantiate(prefab, transform.position, Quaternion.identity);
       }

       private GameObject GetRandomPrefab()
       {
        if(prefab.Length==0)
        {
            return null;
        }

        int index = Random.Range(0,prefab.Length);
        return prefab[index];
       }
    }
}