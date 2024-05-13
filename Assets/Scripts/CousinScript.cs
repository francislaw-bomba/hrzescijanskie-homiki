using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CousinScript : MonoBehaviour
{
    [SerializeField] private PlayerValues PlayerVal;
    [SerializeField] public int Debt;
    [SerializeField] private float CousinTimer;
    [SerializeField] public bool IsIllegalPlantPlanted;
    [SerializeField] private GameObject IllegalPlant;
    [SerializeField] private Sprite CousinScreen, CousinCallScreen, CousinPayScreen;
    [SerializeField] private GameObject HiButton, Cousin, PayButton, ByeButton;
    [SerializeField] private Image CousinImage;

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
                Cousin.SetActive(true);         
            }
        }

        if(Debt <= 0)
        {
            SceneManager.LoadSceneAsync(2);
        }
    }
    public void PayDebt()
    {
        if(PlayerVal.Money >= 1000)
        {
            PlayerVal.Money -= 1000;
            Debt -= 1000;
            CousinImage.sprite = CousinPayScreen;
        }
    }
    public void IdzSeKuzyn()
    {   
        Time.timeScale = 1f;
        Cousin.SetActive(false);
        HiButton.SetActive(true);
        PayButton.SetActive(false);
        ByeButton.SetActive(false);
        CousinTimer = Random.Range(150, 300);
    }
}
