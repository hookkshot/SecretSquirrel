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
    private Acorn acornPrefab;

    [SerializeField]
    private Transform[] acornSpawns;

    [SerializeField]
    private float gameTime = 120;

    private GameState gameState;

    private float gameTimeElapsed;
    public float RemainingTime
    {
        get { return gameTime - gameTimeElapsed; }
    }

    [SerializeField]
    private float startTime = 4;
    private float startTimeElapsed = 0;

    private bool spawningDuds = false;

    private float acornChange = 20;
    private float acornChangeElapsed;

    private AcornColor acornColor;
    private AcornType acornType;

    private List<PlayerScore> matchWinners = null;
    public UnityEvent<List<PlayerScore>> OnGameOver = new CustomEvent<List<PlayerScore>>();
    public UnityEvent<PlayerScore> OnPlayerScored = new CustomEvent<PlayerScore>();
    public UnityEvent<PlayerScore> OnPlayerTricked = new CustomEvent<PlayerScore>();
    public UnityEvent<AcornColor> OnAcornChanged = new CustomEvent<AcornColor>();

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

        acornColor = AcornColor.Natural;
        acornType = AcornType.Normal;
        OnAcornChanged.Invoke(acornColor);
    }

    // Start is called before the first frame update
    void Start()
    {
        gameState = GameState.Starting;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameState == GameState.Starting)
        {
            if(startTimeElapsed >= startTime)
            {
                startTimeElapsed = 0;
                gameState = GameState.Playing;
                for (int i = 0; i < Mathf.Max(1, MasterManager.Players.Count - 1); i++)
                {
                    SpawnAcorn();
                }
                return;
            }
            else
            {
                startTimeElapsed += Time.deltaTime;
            }
        }
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

                //TODO Change players to no more input.
            }
            else
            {
                gameTimeElapsed += Time.deltaTime;
            }

            if(acornChangeElapsed > acornChange)
            {
                acornChangeElapsed -= acornChange;
                ChangeAcorns();
            }
            else
            {
                acornChangeElapsed += Time.deltaTime;
            }
        }
    }

    private void SpawnAcorn()
    {
        var acorn = Instantiate(acornPrefab, acornSpawns[Random.Range(0, acornSpawns.Length)].position, Quaternion.identity);
        acorn.Dud = acornType == AcornType.Dud;
        acorn.ChangeType(acornColor);

        Debug.Log($"Acorn is {acornType.ToString()} and {acornColor.ToString()}");
    }

    private void ChangeAcorns()
    {
        Debug.Log("Change acorns");
        acornType = Random.Range(0f, 1f) > 0.7f ? AcornType.Dud : AcornType.Normal;

        switch (acornColor)
        {
            case AcornColor.Natural:
                acornColor = AcornColor.Glass;
                break;
            case AcornColor.Iron:
                acornColor = AcornColor.Natural;
                break;
            case AcornColor.Glass:
                acornColor = AcornColor.Iron;
                break;
        }
        OnAcornChanged.Invoke(acornColor);
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

        SpawnAcorn();
    }
}

public enum GameState
{
    Playing = 0,
    Paused = 1,
    GameOver = 2,
    Starting = 3,
}

public class PlayerScore
{
    public int Score;
    public PlayerInput Player;
}
