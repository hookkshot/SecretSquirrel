using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuScreen : MonoBehaviour
{
    [SerializeField]
    private Button startGameButton;

    [SerializeField]
    private Button quitButton;

    [SerializeField]
    private GameObject startGameScreen;

    private void OnEnable()
    {
        startGameButton.onClick.AddListener(OnStartGameClick);
        quitButton.onClick.AddListener(OnQuitButtonClick);
    }

    private void OnDisable()
    {
        startGameButton.onClick.RemoveListener(OnStartGameClick);
        quitButton.onClick.RemoveListener(OnQuitButtonClick);
    }

    private void OnStartGameClick()
    {
        gameObject.SetActive(false);
        startGameScreen.SetActive(true);
    }

    private void OnQuitButtonClick()
    {
        Application.Quit();
    }
}
