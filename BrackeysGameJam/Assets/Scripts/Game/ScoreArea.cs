using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreArea : MonoBehaviour
{
    [SerializeField]
    private int playerIndex = 0;

    [SerializeField]
    private AudioClip soundDud;

    [SerializeField]
    private AudioClip soundScore;

    private GameManager manager;
    private AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
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

        if (acorn.Dud)
        {
            audio.clip = soundDud;
            audio.Play();
        }
        else
        {
            audio.clip = soundScore;
            audio.Play();
        }
    }
}
