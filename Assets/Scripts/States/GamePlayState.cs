using Golf;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using TMPro;

namespace Golf
{
public class GamePlayState : GameState
{
    public LevelControllet levelController;
    public PlayerController playerController;
    public  GameState gameOverState;
    public TMP_Text scoreText;

    protected override void OnEnable()
    {
        base.OnEnable();
        levelController.enabled = true;
        playerController.enabled = true;
        
        GameEvents.onCollisionStone += OnGameOver;
        GameEvents.onStickHit +=OnStickHit;
    }
    private void OnStickHit()
    {
        scoreText.text = $"Score : {levelController.score}";
    }
    private void OnGameOver()
    {
        Exit();
        gameOverState.Enter();
    }
    protected override void OnDisable()
    {
        base.OnDisable();

        levelController.enabled = false;
        playerController.enabled = false;

        GameEvents.onCollisionStone -= OnGameOver;
    }
}
}
