using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopVoids : MonoBehaviour
{
    [SerializeField] private PlayerValues PlayerVal;
    void Start()
    {
        PlayerVal = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PlayerValues>();
    }

    public void BuyLemonSeeds()
    {
        if (PlayerVal.Money >= 300)
        {
            PlayerVal.Money -= 300;
            PlayerVal.Lemon.SeedCount += 1;
        }
    }
    public void BuyMangoSeeds()
    {
        if (PlayerVal.Money >= 500)
        {
            PlayerVal.Money -= 500;
            PlayerVal.Mango.SeedCount += 1;
        }
    }
    public void BuyDragonFruitSeeds()
    {
        if (PlayerVal.Money >= 700)
        {
            PlayerVal.Money -= 700;
            PlayerVal.DragonFruit.SeedCount += 1;
        }
    }
    public void BuyPineappleSeeds()
    {
        if (PlayerVal.Money >= 900)
        {
            PlayerVal.Money -= 900;
            PlayerVal.Pineapple.SeedCount += 1;
        }
    }
    public void BuyPurpleLemonSeeds()
    {
        if(PlayerVal.Money >= 1000)
        {
            PlayerVal.Money -= 1000;
            PlayerVal.PurpleLemon.SeedCount += 1;
        }
    }
    public void BuyBlueTomatoSeeds()   
    {
        if (PlayerVal.Money >= 100)
        {
            PlayerVal.Money -= 100;
            PlayerVal.BlueTomato.SeedCount += 1;
        }
    }
    public void BuyTurqPeachSeeds()
    {
        if (PlayerVal.Money >= 100)
        {
            PlayerVal.Money -= 100;
            PlayerVal.TurqPeach.SeedCount += 1;
        }
    }
}
