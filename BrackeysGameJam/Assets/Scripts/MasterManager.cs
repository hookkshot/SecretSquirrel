using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            SceneManager.LoadScene(mainMenuScene);
        }
    }

    public static void MainMenu()
    {
        SceneManager.LoadScene(_instance.mainMenuScene);
    }

    public static void Game()
    {
        SceneManager.LoadScene(_instance.gameScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
