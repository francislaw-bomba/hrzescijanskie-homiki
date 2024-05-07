using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CousinScript : MonoBehaviour
{
    [SerializeField] private PlayerValues PlayerVal;
    [SerializeField] public int Debt;
    [SerializeField] private float CousinTimer;
    [SerializeField] public bool IsIllegalPlantPlanted;
    [SerializeField] private GameObject IllegalPlant;

    void Start()
    {
        PlayerVal = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PlayerValues>();
        Debt = 50000;
        CousinTimer = Random.Range(120, 300);
    }

    void Update()
    {
        IllegalPlant = GameObject.FindGameObjectWithTag("IllegalPlant");

        if (IllegalPlant == null)
        {
            IsIllegalPlantPlanted = false;
        }
        else if (IllegalPlant != null)
        {
            IsIllegalPlantPlanted = true;
        }

        if (CousinTimer > 0)
        {
            CousinTimer -= Time.deltaTime;
        }
        else
        {        
            if (IsIllegalPlantPlanted == true)
            {
                //ewentualnie cutscenka policji czy chun
                SceneManager.LoadSceneAsync(3);
            }
            else
            {
                Time.timeScale = 0f;
                //respi sie kuzyn guziki sa itp                
            }
        }
        if(Debt <= 0)
        {
            SceneManager.LoadSceneAsync(2);
        }
    }
    public void PayDebt()
    {
        PlayerVal.Money -= 1000;
        Debt -= 1000;
    }
    public void IdzSeKuzyn()
    {
        //despawnuje kuzyna
        Time.timeScale = 1f;
        CousinTimer = Random.Range(150, 300);
    }
}
