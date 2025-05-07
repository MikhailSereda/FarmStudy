using System.Collections.Generic;
using UnityEngine;
namespace Golf
{
    public class GameState : MonoBehaviour
    {
        public List<GameObject> views;
        
        public virtual void Enter()
        {
            gameObject.SetActive(true);
        }

        public virtual void Exit()
        {
            gameObject.SetActive(false);
        }

        protected virtual void OnEnable()
        {
            foreach(var items in views)
            {
                items.SetActive(true);
            }
        }

        protected virtual void OnDisable()
        {
            foreach(var items in views)
            {
                if(items)
                {
                    items.SetActive(false);
                }
            }
        }
    }
}
