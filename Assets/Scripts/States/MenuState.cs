using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using TZ;
namespace Golf
{
    public class MenuState : GameState
    {
        public GameState gamePlayState;
        public LevelControllet levelController;
        public TMP_Text scoreText;
        public BigStonePlayerController stoneButton;
        public BigStonePlayerController cloudButton;
        public BigStonePlayerController handButton;

        public void PlayGame()
        {
            Exit();
            gamePlayState.Enter();
        }
        protected override void OnEnable()
        {
            base.OnEnable();
            scoreText.text = $"Рекорд : {levelController.hightScore}";
           
        }
        private void StoneButtons()
        {
            Exit();
            stoneButton.Enter();
        }
        private void CloudButtons()
        {
            Exit();
            cloudButton.Enter();
        }
        private void HandButtons()
        {
            Exit();
            handButton.Enter();
        }
        
    }
}
