using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StartGameScreen : MonoBehaviour
{
    private const string PLAYERS_NEED_TO_JOIN = "Press the A button to join, minimum 2 players needed";
    private const string CAN_START = "Press the A button to join, press start to play";
    private const string ONLY_START = "Press start to play";

    private InputManager inputManager;

    [SerializeField]
    private TMP_Text joinText;

    private void Awake()
    {
        inputManager = new InputManager();
    }

    private void OnEnable()
    {
        StartCoroutine(StartListening());
        inputManager.Enable();
        inputManager.Menu.Start.performed += ctx => OnStart();
        joinText.text = PLAYERS_NEED_TO_JOIN;
    }

    private IEnumerator StartListening()
    {
        yield return new WaitForSeconds(0.3f);
        MasterManager.OnPlayerJoined.AddListener(OnPlayerJoined);
        MasterManager.OnPlayerLeft.AddListener(OnPlayerLeft);
        MasterManager.StartListeningForPlayers();
    }

    private void OnDisable()
    {
        MasterManager.StopListeningForPlayers();
        MasterManager.OnPlayerJoined.RemoveListener(OnPlayerJoined);
        MasterManager.OnPlayerLeft.RemoveListener(OnPlayerLeft);
        inputManager.Disable();
        inputManager.Menu.Start.performed -= ctx => OnStart();
    }

    private void OnPlayerJoined(UnityEngine.InputSystem.PlayerInput input)
    {
        Debug.Log("Player joined");
        if(MasterManager.Players.Count > 1)
        {
            joinText.text = CAN_START;
        }
        else if(MasterManager.Players.Count == 4)
        {
            joinText.text = ONLY_START;
        }
    }

    private void OnPlayerLeft(UnityEngine.InputSystem.PlayerInput input)
    {
        if (MasterManager.Players.Count < 2)
        {
            joinText.text = PLAYERS_NEED_TO_JOIN;
        }
        else if (MasterManager.Players.Count < 4)
        {
            joinText.text = CAN_START;
        }
    }

    private void OnStart()
    {
        if (MasterManager.Players.Count > 1)
        {
            MasterManager.Game();
        }
    }
}
