using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class LevelControllet : MonoBehaviour
    {
        public Spawner spawner;
        public float dalay = 0.5f;
        public bool isGameOver = false;

        private void Start()
        {
            StartCoroutine(StartStoneProc());
        }

        private IEnumerator StartStoneProc()
        {
            do
            {
                yield return new WaitForSeconds(dalay);
                spawner.Spawn();
            }
            while (!isGameOver);
        }
    }
}
