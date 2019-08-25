using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class Player : MonoBehaviour
{
    private Vector2 moveDirection;

    [SerializeField]
    private GameObject inGameUi;

    [SerializeField]
    private GameObject menuUi;

    [SerializeField]
    private GameObject gameRenderer;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        SwitchToMenu();

        //var playerInput = GetComponent<PlayerInput>();

        //playerInput.actionEvents
    }

    #region Input

    public void Move(CallbackContext ctx)
    {
        moveDirection = ctx.ReadValue<Vector2>();
    }

    public void Action1(CallbackContext ctx)
    {

    }

    public void Action2(CallbackContext ctx)
    {

    }

    #endregion

    public void SwitchToMenu()
    {
        inGameUi.SetActive(false);
        menuUi.SetActive(true);
        gameRenderer.SetActive(false);
    }

    public void SwitchToGame()
    {
        inGameUi.SetActive(true);
        menuUi.SetActive(false);
        gameRenderer.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection * 3 * Time.deltaTime);
    }
}
