using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class GameUi : MonoBehaviour
{
    [SerializeField]
    private TMP_Text timerText;

    [SerializeField]
    private TMP_Text[] scoreTexts;

    [SerializeField]
    private TMP_Text gameOverText;

    private GameManager gameManager;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

        gameManager.OnGameOver.AddListener(OnGameOver);
        gameManager.OnPlayerScored.AddListener(OnScore);
        gameManager.OnPlayerTricked.AddListener(OnTrick);

        animator = GetComponent<Animator>();

        for (int i = 0; i < scoreTexts.Length; i++)
        {
            var scoreText = scoreTexts[i];

            scoreText.gameObject.SetActive(i < MasterManager.Players.Count);
        }
    }

    private void OnGameOver(List<PlayerScore> winners)
    {
        gameOverText.text = $"The winner{(winners.Count > 1 ? "s are" : " is")} {string.Join(" and ", winners.Select(s => "player " + (s.Player.playerIndex+1))) }.";

        animator.SetBool("Playing", false);

        foreach (var score in scoreTexts)
        {
            score.gameObject.SetActive(false);
        }
        SetTimer(0);
    }

    private void OnScore(PlayerScore player)
    {
        UpdateScore(player);
        animator.SetTrigger($"Player{player.Player.playerIndex + 1}Score");
    }

    private void OnTrick(PlayerScore player)
    {
        UpdateScore(player);
    }

    private void UpdateScore(PlayerScore player)
    {
        scoreTexts[player.Player.playerIndex].text = player.Score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        SetTimer(gameManager.RemainingTime);
    }

    private void SetTimer(float time)
    {
        timerText.text = time.ToString("N2");
    }
}
