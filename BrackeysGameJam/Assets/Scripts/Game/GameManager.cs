using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Transform[] spawns;

    private List<PlayerScore> scores;

    private void Awake()
    {
        scores = new List<PlayerScore>();

        foreach (var playerInput in MasterManager.Players)
        {
            playerInput.ActivateInput();
            playerInput.SwitchCurrentActionMap("Game");

            var playerMotor = playerInput.GetComponent<Player>();
            playerMotor.SwitchToGame();

            playerInput.transform.position = spawns[playerInput.playerIndex].position;
            var score = new PlayerScore();
            score.player = playerInput;
            scores.Add(score);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class PlayerScore
{
    public int Score;
    public PlayerInput player;
}
