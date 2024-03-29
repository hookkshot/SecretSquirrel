﻿using System.Collections;
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

    [SerializeField]
    private GameObject announcementUi;

    [SerializeField]
    private TMP_Text announcementText;

    [SerializeField]
    private Animator announcementAnimator;

    private GameManager gameManager;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

        gameManager.OnGameOver.AddListener(OnGameOver);
        gameManager.OnPlayerScored.AddListener(OnScore);
        gameManager.OnPlayerTricked.AddListener(OnTrick);
        gameManager.OnAcornChanged.AddListener(OnAcornChange);

        animator = GetComponent<Animator>();
        announcementUi.SetActive(false);

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

    private void OnAcornChange(AcornColor color)
    {
        var message = $"We now have {color.ToString()} acorns which are {(Random.Range(0, 2) == 0 ? "not " : "")}safe to eat.";
        Announcement(message);
    }

    private void Announcement(string message)
    {
        StartCoroutine(IAnnouncement(message));
    }

    private IEnumerator IAnnouncement(string message)
    {
        announcementUi.SetActive(true);
        announcementText.text = message;
        yield return new WaitForSeconds(4);
        announcementUi.SetActive(false);
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
