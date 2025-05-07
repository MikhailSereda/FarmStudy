using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
namespace Golf
{
    public class MenuState : GameState
    {
        public GameState gamePlayState;
        public LevelControllet levelController;
        public TMP_Text scoreText;

        public void PlayGame()
        {
            Exit();
            gamePlayState.Enter();
        }
        protected override void OnEnable()
        {
            base.OnEnable();
            scoreText.text = $"HScore : {levelController.hightScore}";
        }
    }
}
