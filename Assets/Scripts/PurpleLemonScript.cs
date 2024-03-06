using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleLemonScript : MonoBehaviour
{
    [SerializeField] private Sprite Stage2, Stage3, Stage4, Stage5;
    [SerializeField] private float GrowthTime = 60f;
    [SerializeField] public float WaterLevel = 10f;
    [SerializeField] public float MaxWaterLevel = 10f;
    [SerializeField] private float TimeRemaning;
    [SerializeField] private SpriteRenderer Sprite;
    [SerializeField] WaterLevelScript WaterLevelScript;
    [SerializeField] private GameObject WaterButton;
    [SerializeField] private GameObject WaterLevelSlider;
    [SerializeField] private GameObject HarvestButton;
    [SerializeField] private CavansScript CavansScript;
    [SerializeField] public PlayerValues PlayerVal;
    [SerializeField] private PotScript ScriptPot;
    [SerializeField] private bool isDry = false;
    [SerializeField] private float LifeTimeRemaning = 3f;

    void Start()
    {
        PlayerVal = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PlayerValues>();
        TimeRemaning = GrowthTime;
        WaterLevelScript = GetComponentInChildren<WaterLevelScript>();
        CavansScript = GetComponentInChildren<CavansScript>();
        WaterButton = CavansScript.WaterButton;
        WaterLevelSlider = CavansScript.WaterLevel;
        HarvestButton = CavansScript.HarvestButton;
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

        if (TimeRemaning < 45 && TimeRemaning > 30)
        {
            Sprite.sprite = Stage2;
        }
        else if (TimeRemaning < 30 && TimeRemaning > 15)
        {
            Sprite.sprite = Stage3;
        }
        else if (TimeRemaning < 15 && TimeRemaning > 0)
        {
            Sprite.sprite = Stage4;
        }
        else if (TimeRemaning <= 0)
        {
            Sprite.sprite = Stage5;
            Destroy(WaterButton);
            Destroy(WaterLevelSlider);
            HarvestButton.SetActive(true);
        }
        if (WaterLevel <= 0)
        {
            isDry = true;
        }
        else
        {
            isDry = false;
        }
        if (isDry == true)
        {
            LifeTimeRemaning -= Time.deltaTime;
        }
        if (LifeTimeRemaning <= 0)
        {
            PlantDried();
        }
    }

    public void WaterPlant()
    {
        WaterLevel = MaxWaterLevel;
    }
    public void Harvested()
    {
        ScriptPot = GetComponentInParent<PotScript>();
        PlayerVal.AddPurpleLemons(5);
        Destroy(gameObject);
        ScriptPot.IsOccupied = false;
    }
    public void PlantDried()
    {
        ScriptPot = GetComponentInParent<PotScript>();
        Destroy(gameObject);
        ScriptPot.IsOccupied = false;
    }
}
