using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class LevelControllet : MonoBehaviour
    {
        public Spawner spawner;
        public float delayStep = 0.1f;
        public float delayMax = 2f;
        public float delayMin = 0.5f;
        private float m_delay = 0.5f;

        private float m_lastSpawnedTime = 0;

        public int score = 0;
        public int hightScore = 0;

        private List<GameObject> m_stone = new List<GameObject>(16);

        private void Start()
        {
            m_lastSpawnedTime = Time.time;
            RefreshDelay();
        }
    
        private void OnStick()
        {
            score++;
            hightScore = Mathf.Max(score,hightScore);
            Debug.Log($"score: {score} - hightScore:{hightScore}");
        }
        private void OnEnable()
        {

                   GameEvents.onStickHit += OnStick;
                   score = 0;
        }
        private void OnDisable()
        {

                   GameEvents.onStickHit -= OnStick;
        }
        private void GameOver()
        {
            Debug.Log("Game Over");
            enabled = false;
        }

        public void ClearStones()
        {
            foreach (var stone in m_stone)
            {
                Destroy(stone);
            }
            m_stone.Clear();
        }

        private void RefreshDelay()
        {
            m_delay = UnityEngine.Random.Range(delayMin, delayMax);
            delayMax = Mathf.Max(delayMin, delayMax - delayStep);
        }
        private void Update()
        {
            
            if (Time.time >= m_lastSpawnedTime + m_delay)
            {
                var stone = spawner.Spawn();
                m_stone.Add(stone);
                m_lastSpawnedTime = Time.time;
                RefreshDelay();
            }
           
        }
    }
}
