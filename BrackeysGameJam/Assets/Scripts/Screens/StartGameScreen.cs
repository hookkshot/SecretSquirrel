using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameScreen : MonoBehaviour
{
    private InputManager inputManager;

    private void Awake()
    {
        inputManager = new InputManager();
    }

    private void OnEnable()
    {
        StartCoroutine(StartListening());
        inputManager.Enable();
        inputManager.Menu.Start.performed += ctx => OnStart();
    }

    private IEnumerator StartListening()
    {
        yield return new WaitForSeconds(0.3f);
        MasterManager.StartListeningForPlayers();
    }

    private void OnDisable()
    {
        MasterManager.StopListeningForPlayers();
        inputManager.Disable();
        inputManager.Menu.Start.performed -= ctx => OnStart();
    }

    private void OnStart()
    {
        MasterManager.Game();
    }
}
