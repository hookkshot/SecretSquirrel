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
    private Sprite chiliSprite;

    [SerializeField]
    private Sprite driedSprite;

    [SerializeField]
    private Sprite lemonSprite;

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
            case AcornColor.Dried:
                renderer.sprite = driedSprite;
                break;
            case AcornColor.Chilli:
                renderer.sprite = chiliSprite;
                break;
            case AcornColor.Lemon:
                renderer.sprite = lemonSprite;
                break;
        }
    }
}

public enum AcornColor
{
    Natural = 0,
    Dried = 1,
    Chilli = 2,
    Lemon = 3,
}

public enum AcornType
{
    Normal,
    Dud,
}