using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LemonScript : MonoBehaviour
{
    [SerializeField] private Sprite Stage2, Stage3, Stage4, Stage5;
    [SerializeField] private float GrowthTime = 20f;
    [SerializeField] public float WaterLevel = 7f;
    [SerializeField] public float MaxWaterLevel = 7f;
    [SerializeField] private float TimeRemaning;
    [SerializeField] private SpriteRenderer LemonSprite;
    [SerializeField] WaterLevelScript WaterLevelScript;
    [SerializeField] private GameObject WaterButton;
    [SerializeField] private GameObject WaterLevelSlider;
    [SerializeField] private CavansScript CavansScript;

    void Start()
    {
        TimeRemaning = GrowthTime;
        WaterLevelScript = GameObject.FindGameObjectWithTag("WaterLevel").GetComponent<WaterLevelScript>();
        CavansScript = GetComponentInChildren<CavansScript>();
        WaterButton = CavansScript.WaterButton;
        WaterLevelSlider = CavansScript.WaterLevel;
    }

    void Update()
    {
        if (TimeRemaning > 0 && WaterLevel > 0)
        {
            TimeRemaning -= Time.deltaTime;
            WaterLevel -= Time.deltaTime;
            WaterLevelScript.UpdateWaterBar(WaterLevel, MaxWaterLevel);
        }
        if (WaterLevel < 1.5)
        {
            WaterButton.SetActive(true);
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
            Destroy(WaterButton);
            Destroy(WaterLevelSlider);
        }
    }

    public void WaterPlant()
    {
        WaterLevel = MaxWaterLevel;
    }
}
