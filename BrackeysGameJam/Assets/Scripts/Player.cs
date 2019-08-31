using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class Player : MonoBehaviour
{
    private Vector2 moveDirection;
    private Rigidbody2D rigidbody;

    [SerializeField]
    private GameObject inGameUi;

    [SerializeField]
    private GameObject menuUi;

    [SerializeField]
    private GameObject gameRenderer;

    private Animator animator;
    private PlayerDirection direction;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        SwitchToMenu();
        rigidbody = GetComponent<Rigidbody2D>();

        animator = GetComponent<Animator>();
    }

    #region Input

    public void Move(CallbackContext ctx)
    {
        var direction = ctx.ReadValue<Vector2>();
        if(direction.magnitude < 0.1f)
        {
            direction = Vector2.zero;
        }

        moveDirection = direction;

        var xAbs = Mathf.Abs(moveDirection.x);
        var yAbs = Mathf.Abs(moveDirection.y);

        if (moveDirection.x < 0)
        {
            MoveDirection(PlayerDirection.Left);
        }
        else if(moveDirection.x > 0)
        {
            MoveDirection(PlayerDirection.Right);
        }
        else
        {
            MoveDirection(PlayerDirection.None);
        }

        //if(yAbs == 0 & xAbs == 0)
        //{
        //    MoveDirection(PlayerDirection.None);
        //}
        //else if(yAbs < xAbs)
        //{
        //    if (moveDirection.y > 0)
        //    {
        //        MoveDirection(PlayerDirection.Up);
        //    }
        //    else
        //    {
        //        MoveDirection(PlayerDirection.Down);
        //    }
        //}
        //else
        //{
        //    if (moveDirection.x <= 0)
        //    {
        //        MoveDirection(PlayerDirection.Left);
        //    }
        //    else
        //    {
        //        MoveDirection(PlayerDirection.Right);
        //    }
        //}
    }

    public void MoveDirection(PlayerDirection newDirection)
    {
        if(newDirection != direction)
        {
            switch (newDirection)
            {
                case PlayerDirection.Left:
                    animator.SetInteger("Direction", 0);
                    animator.SetBool("Running", true);
                    break;
                case PlayerDirection.Right:
                    animator.SetInteger("Direction", 2);
                    animator.SetBool("Running", true);
                    break;
                case PlayerDirection.Up:
                    animator.SetInteger("Direction", 1);
                    animator.SetBool("Running", true);
                    break;
                case PlayerDirection.Down:
                    animator.SetInteger("Direction", 3);
                    animator.SetBool("Running", true);
                    break;
                case PlayerDirection.None:
                    animator.SetBool("Running", false);
                    break;
            }

            direction = newDirection;
        }
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
        rigidbody.velocity = (moveDirection * 3);
        //transform.Translate(moveDirection * 3 * Time.deltaTime);
    }
}

public enum PlayerDirection
{
    Left,
    Right,
    Up,
    Down,
    None,
}