using Golf;
using UnityEngine;
using TMPro;

public class GameOverState : GameState
{
    public GameState menuState;
    public LevelControllet levelController;
     public TMP_Text scoreText;

    public void Restart()
    {
        levelController.ClearStones();

        Exit();
        menuState.Enter();
    }
    protected override void OnEnable()
    {
        base.OnEnable();
        GameEvents.onStickHit +=OnStickHit;
    }
    private void OnStickHit()
    {
        scoreText.text = $"Score : {levelController.score}";
    }
}
