using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Linq;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Transform[] spawns;

    [SerializeField]
    private GameObject[] scoreAreas;

    private List<PlayerScore> scores;

    [SerializeField]
    private float gameTime = 120;

    private GameState gameState;

    private float gameTimeElapsed;
    public float RemainingTime
    {
        get { return gameTime - gameTimeElapsed; }
    }

    private List<PlayerScore> matchWinners = null;
    public UnityEvent<List<PlayerScore>> OnGameOver = new CustomEvent<List<PlayerScore>>();
    public UnityEvent<PlayerScore> OnPlayerScored = new CustomEvent<PlayerScore>();
    public UnityEvent<PlayerScore> OnPlayerTricked = new CustomEvent<PlayerScore>();

    private void Awake()
    {
        scores = new List<PlayerScore>();

        foreach (var scoreArea in scoreAreas)
        {
            scoreArea.SetActive(false);
        }

        foreach (var playerInput in MasterManager.Players)
        {
            playerInput.ActivateInput();
            playerInput.SwitchCurrentActionMap("Game");

            var playerMotor = playerInput.GetComponent<Player>();
            playerMotor.SwitchToGame();

            playerInput.transform.position = spawns[playerInput.playerIndex].position;
            scoreAreas[playerInput.playerIndex].SetActive(true);
            var score = new PlayerScore();
            score.Player = playerInput;
            scores.Add(score);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gameState = GameState.Playing;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameState == GameState.Playing)
        {
            if(gameTimeElapsed > gameTime)
            {
                gameState = GameState.GameOver;
                gameTimeElapsed = gameTime;

                //Find match winners
                matchWinners = scores.Where(s => s.Score == scores.Max(x => x.Score)).ToList();
                OnGameOver.Invoke(matchWinners);
                StartCoroutine(GameOverTimer());
            }
            else
            {
                gameTimeElapsed += Time.deltaTime;
            }
        }
    }

    private IEnumerator GameOverTimer()
    {
        yield return new WaitForSeconds(6);
        MasterManager.MainMenu();
    }
    public void PlayerScore(int playerIndex, Acorn acorn)
    {
        var player = scores.FirstOrDefault(s => s.Player.playerIndex == playerIndex);
        if (acorn.Dud)
        {
            player.Score = Mathf.Max(0, player.Score-2);
            OnPlayerTricked.Invoke(player);
        }
        else
        {
            player.Score++;
            OnPlayerScored.Invoke(player);
        }
    }
}

public enum GameState
{
    Playing = 0,
    Paused = 1,
    GameOver = 2,
}

public class PlayerScore
{
    public int Score;
    public PlayerInput Player;
}
