using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameUi : MonoBehaviour
{
    [SerializeField]
    private TMP_Text timerText;

    [SerializeField]
    private TMP_Text[] scoreTexts;

    [SerializeField]
    private TMP_Text gameOverText;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

        gameManager.OnGameOver.AddListener(OnGameOver);
        gameManager.OnPlayerScored.AddListener(OnScore);
        gameManager.OnPlayerScored.AddListener(OnScore);

        gameOverText.gameObject.SetActive(false);

        for (int i = 0; i < scoreTexts.Length; i++)
        {
            var scoreText = scoreTexts[i];

            scoreText.gameObject.SetActive(i < MasterManager.Players.Count);
        }
    }

    private void OnGameOver(List<PlayerScore> winners)
    {
        gameOverText.gameObject.SetActive(true);
        foreach (var score in scoreTexts)
        {
            score.gameObject.SetActive(false);
        }
        SetTimer(0);
    }

    private void OnScore(PlayerScore player)
    {
        UpdateScore(player);
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
