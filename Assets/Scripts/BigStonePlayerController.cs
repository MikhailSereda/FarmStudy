using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
namespace TZ
{
    public class BigStonePlayerController : MonoBehaviour
    {
        public BigStoneSpawner spawner;
        public CloudController cloudcontroller;
        public List <Refresh> villagers;

        public void ClickStone()
        {
            spawner.Spawn();
        }
        public void ClickCloud()
        {
            cloudcontroller.Action();
        }
        public void ClickHend()
        {
            foreach (var villager in villagers)
            {
            villager.ChangeTool();
            }
        }
        public virtual void Enter()
        {
            gameObject.SetActive(true);
        }

        public virtual void Exit()
        {
            gameObject.SetActive(false);
        }
         
    }
}