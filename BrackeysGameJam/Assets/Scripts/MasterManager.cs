using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.InputSystem;
using UnityEngine.Events;

public class MasterManager : MonoBehaviour
{
    #region Singleton

    private static MasterManager _instance;

    #endregion

    #region Scenes

    [Header("Scenes")]
    [SerializeField]
    private string mainMenuScene;

    [SerializeField]
    private string gameScene;

    #endregion

    #region Input

    private PlayerInputManager playerInputManager;
    private List<PlayerInput> players;

    #endregion

    private UnityEvent<PlayerInput> onPlayerJoined = new CustomEvent<PlayerInput>();
    private UnityEvent<PlayerInput> onPlayerLeft = new CustomEvent<PlayerInput>();

    // Start is called before the first frame update
    void Awake()
    {
        if (_instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);

            players = new List<PlayerInput>();
            
            playerInputManager = GetComponent<PlayerInputManager>();
            playerInputManager.onPlayerJoined += PlayerJoined;
            playerInputManager.onPlayerLeft += PlayerLeft;

            MainMenu();
        }
    }

    public static void MainMenu()
    {
        for (int i = Players.Count-1; i >= 0; i--)
        {
            Destroy(Players[i].gameObject);
        }
        Players.Clear();
        SceneManager.LoadScene(_instance.mainMenuScene);
    }

    public static void Game()
    {
        SceneManager.LoadScene(_instance.gameScene);
    }

    public static void StartListeningForPlayers()
    {
        _instance.playerInputManager.EnableJoining();
    }

    public static void StopListeningForPlayers()
    {
        _instance.playerInputManager.DisableJoining();
    }

    private void PlayerJoined(PlayerInput playerInput)
    {
        onPlayerJoined.Invoke(playerInput);
        players.Add(playerInput);
        Debug.Log($"Player {playerInput.playerIndex} joined");
    }

    private void PlayerLeft(PlayerInput playerInput)
    {
        onPlayerLeft.Invoke(playerInput);
        players.Remove(playerInput);
    }

    public static List<PlayerInput> Players
    {
        get { return _instance.players; }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}

public class CustomEvent<T> : UnityEvent<T> { }