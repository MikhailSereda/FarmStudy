using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Golf
{
    public class GameController : MonoBehaviour
    {
       public MenuState menuState;
        
        private void Start()
        {
            menuState.gameObject.SetActive(true);   
        }
    }
}
