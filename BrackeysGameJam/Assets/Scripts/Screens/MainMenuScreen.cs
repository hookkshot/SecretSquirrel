﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuScreen : MonoBehaviour
{
    [SerializeField]
    private Button startGameButton;

    [SerializeField]
    private GameObject startGameScreen;

    private void OnEnable()
    {
        startGameButton.onClick.AddListener(OnStartGameClick);
    }

    private void OnDisable()
    {
        startGameButton.onClick.RemoveListener(OnStartGameClick);
    }

    private void OnStartGameClick()
    {
        gameObject.SetActive(false);
        startGameScreen.SetActive(true);
    }
}
