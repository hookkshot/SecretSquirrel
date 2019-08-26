using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameUi : MonoBehaviour
{
    [SerializeField]
    private TMP_Text timerText;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

        gameManager.OnGameOver.AddListener(OnGameOver);
    }

    private void OnGameOver(List<PlayerScore> winners)
    {
        SetTimer(0);
    }

    // Update is called once per frame
    void Update()
    {
        SetTimer(gameManager.RemainingTime);
    }

    private void SetTimer(float time)
    {
        timerText.text = time.ToString("d2");
    }
}
