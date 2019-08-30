using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acorn : MonoBehaviour
{
    public bool Dud = false;

    private SpriteRenderer renderer;

    [SerializeField]
    private Sprite naturalSprite;

    [SerializeField]
    private Sprite ironSprite;

    [SerializeField]
    private Sprite glassSprite;

    private void Start()
    {
        
    }

    public void ChangeType(AcornColor color)
    {
        renderer = GetComponent<SpriteRenderer>();
        switch (color)
        {
            case AcornColor.Natural:
                renderer.sprite = naturalSprite;
                break;
            case AcornColor.Iron:
                renderer.sprite = ironSprite;
                break;
            case AcornColor.Glass:
                renderer.sprite = glassSprite;
                break;
        }
    }
}

public enum AcornColor
{
    Natural = 0,
    Iron = 1,
    Glass = 2,
}

public enum AcornType
{
    Normal,
    Dud,
}