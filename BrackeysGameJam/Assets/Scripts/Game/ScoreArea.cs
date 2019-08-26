using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreArea : MonoBehaviour
{
    [SerializeField]
    private int playerIndex = 0;

    private GameManager manager;

    // Start is called before the first frame update
    void Start()
    {
        manager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var acorn = collision.gameObject.GetComponent<Acorn>();

        if(acorn != null)
        {
            manager.PlayerScore(playerIndex, acorn);
            Destroy(collision.gameObject);
        }
    }
}
