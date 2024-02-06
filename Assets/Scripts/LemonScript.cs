using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LemonScript : MonoBehaviour
{
    [SerializeField] private Sprite Stage2, Stage3, Stage4, Stage5;
    [SerializeField] private float GrowthTime = 20f;
    [SerializeField] private float TimeRemaning;
    [SerializeField] private SpriteRenderer LemonSprite;
    void Start()
    {
        TimeRemaning = GrowthTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeRemaning > 0)
        {
            TimeRemaning -= Time.deltaTime;
        }
        if (TimeRemaning < 15 && TimeRemaning > 10)
        {
            LemonSprite.sprite = Stage2;
        }
        if (TimeRemaning < 10 && TimeRemaning > 5)
        {
            LemonSprite.sprite = Stage3;
        }
        if (TimeRemaning < 5 && TimeRemaning > 0)
        {
            LemonSprite.sprite = Stage4;
        }
        if (TimeRemaning <= 0)
        {
            LemonSprite.sprite = Stage5;
        }
    }
}
